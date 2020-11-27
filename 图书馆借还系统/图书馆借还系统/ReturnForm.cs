using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书馆借还系统
{
    public partial class ReturnForm : Form
    {
        Main main;

        List<BookLabel> BookList = null;
        //读取书籍信息
        IReader reader;

        SqlDataAdapter da = new SqlDataAdapter();
        DataSet DS = new DataSet();

        public ReturnForm(Main MainWin)
        {
            main = MainWin;
            InitializeComponent();
            reader = new FileReader();
        }

        public void ShowMyWin()
        {
            this.Visible = true;

            DS.Clear();
            BookNum.Value = 0;
        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            main.ReturnMainWin();
        }

        private void button_ReadInfo_Click(object sender, EventArgs e)
        {
            int booknum = (int)BookNum.Value;
            //输出
            if (booknum == 0)
            {
                MessageBox.Show("请输入还书数量!");
                return;
            }
            

            if (BookList == null)
                BookList = new List<BookLabel>();
            else
                BookList.Clear();
            //读取书籍信息
            BookList = reader.GetReader(booknum);
            if (BookList == null)
            {
                MessageBox.Show("未感应到任何书籍!");
                return;
            }
            ///测试
            //booknum = 2;
            //BookList.Add(new BookLabel("L0001", true));
            //BookList.Add(new BookLabel("L0002", true));

            //剔除没被借走的书籍
            BookList.RemoveAll(book => book.SIG == true);

            if (BookList.Count() == 0)
            {
                MessageBox.Show("未感应到任何书籍!");
                return;
            }

            SqlConnection con = SqlConnect.getConn();

            try
            {
                if (!DS.Tables.Contains("books"))//判断是否有表
                {
                    DataTable bookTable = new DataTable("books");
                    DS.Tables.Add(bookTable);
                }
                else
                    DS.Tables["books"].Clear();


                //循环遍历读到的标签号，其中剔除掉已经被借走的书籍
                for (int i = 0; i < BookList.Count(); i++)
                {
                    //创建查询语句
                    string SelectText = "select * from V_Return where L_Id = " + "'" + BookList[i].ID + "' and BR_IsReturn = 0";
                    //定义创建sqlcommand并赋值给da
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SelectText;
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

                    con.Open();
                    //获取一本书
                    
                    da.Fill(DS, "books");
                    con.Close();
                }

                //将读到绑定到GridView上
                GridView_Return.AutoGenerateColumns = false;
                //设置列的对应关系
                GridView_Return.Columns["Col1_BookName"].DataPropertyName = "B_Name";
                GridView_Return.Columns["Col1_Label"].DataPropertyName = "L_Id";
                GridView_Return.Columns["Col1_BookId"].DataPropertyName = "B_Id";
                GridView_Return.Columns["Col1_Reader"].DataPropertyName = "P_Id";
                //GridView_Return.Columns["Col1_Start"].DataPropertyName = "BR_Start";

                //绑定
                GridView_Return.DataSource = DS;
                GridView_Return.DataMember = "books";

                DateTime dateTime = DateTime.Now;
                DateTime startTime;
                DateTime deadlineTime;

                for (int i = 0; i < GridView_Return.Rows.Count; i++)
                {
                    startTime = (DateTime)DS.Tables["books"].Rows[i]["BR_Start"];
                    deadlineTime = startTime.AddDays(30);
                    
                    GridView_Return.Rows[i].Cells["Col1_Deadline"].Value = deadlineTime.ToString();
                    GridView_Return.Rows[i].Cells["Col1_Start"].Value = startTime.ToString();


                    TimeSpan daysSpan = new TimeSpan(dateTime.Ticks - startTime.Ticks);
                    DS.Tables["books"].Rows[i]["BR_Time"] = (int)daysSpan.TotalDays;

                    if (dateTime.CompareTo(deadlineTime) >0)
                        GridView_Return.Rows[i].Cells["Col1_Status"].Value = "已超时";
                    else
                        GridView_Return.Rows[i].Cells["Col1_Status"].Value = "借阅中";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("读取书籍失败!");
                return;
            }
            finally
            {
                con.Close();
            }
        }

        //提交按钮
        private void Submmit_Click(object sender, EventArgs e)
        {
            if (BookList == null)
            {
                MessageBox.Show("请先读取书籍后再提交！");
                return;
            }

            //先写卡
            for (int i = 0; i < BookList.Count(); i++)
            {
                BookList[i].SIG = true;
            }
            if(!reader.SetReader(BookList))
            {
                MessageBox.Show("写标签失败！请不要在操作期间移动书本！");
                return;
            }

            //再写数据库
            //新建连接对象
            SqlConnection conn = SqlConnect.getConn();
            conn.Open();

            for (int i = 0; i < DS.Tables["books"].Rows.Count; i++)
            {
                //拼接命令字符串
                string updateQuery = "update T_Borrow set BR_IsReturn=1,BR_Time = @ReadTime where P_Id=@userId and  L_Id=@labelId and BR_Start=@starttime";
                //新建命令对象
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                //添加参数
                cmd.Parameters.Add(new SqlParameter("@ReadTime", DS.Tables["books"].Rows[i]["BR_Time"]));
                cmd.Parameters.Add(new SqlParameter("@userId", DS.Tables["books"].Rows[i]["P_Id"]));
                cmd.Parameters.Add(new SqlParameter("@labelId", DS.Tables["books"].Rows[i]["L_Id"]));
                cmd.Parameters.Add(new SqlParameter("@starttime", DS.Tables["books"].Rows[i]["BR_Start"]));
                
                //保存执行结果
                cmd.ExecuteNonQuery();
            }
            
            conn.Close();

            //图书馆藏数-1
            for (int i = 0; i < GridView_Return.Rows.Count; i++)
            {
                string bookId = GridView_Return.Rows[i].Cells["Col1_BookId"].Value.ToString();

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "updata  T_Book set B_CountNow = B_CountNow+1 where B_Id ='" + bookId + "'";
                    //MessageBox.Show(cmd.CommandText); //for test
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("更新图书数目失败！");
                }
                finally
                {
                    if (conn != null)
                        conn.Close();
                }
            }

            MessageBox.Show("还书成功!点击退出登录!");
            //返回主界面
            main.ReturnMainWin();

        }
    }
}
