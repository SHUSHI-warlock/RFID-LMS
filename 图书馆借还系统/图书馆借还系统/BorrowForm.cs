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
    public partial class BorrowForm : Form
    {
        Main main;
        string pId = "";
        List<BookLabel> BookList = null;

        SqlDataAdapter da = new SqlDataAdapter();
        DataSet DS = new DataSet();

        public BorrowForm(Main MainWin)
        {
            main = MainWin;
            InitializeComponent();

        }

        public void ShowMyWin(string UserId)
        {
            this.Visible = true;
            //清空
            pId = UserId;
            DS.Clear();
            BookNum.Value = 0;
        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            main.ReturnMainWin();
        }

        //读取书籍信息并显示
        private void button_ReadInfo_Click(object sender, EventArgs e)
        {
            int booknum = (int)BookNum.Value;
            //输出
            Console.WriteLine("booknum = " + booknum.ToString());
            if (booknum == 0)
            {
                MessageBox.Show("请输入借书数量!");
                return;
            }
            //读取书籍信息
            RFIDReader reader = new RFIDReader();

            if (BookList == null)
                BookList = new List<BookLabel>();
            else
                BookList.Clear();
            //List<BookLabel> BookList = reader.GetReader(booknum);
            ///测试
            booknum = 3;
            BookList.Add(new BookLabel("L0001",false));
            BookList.Add(new BookLabel("L0002", false));
            BookList.Add(new BookLabel("L0004", true));

            //剔除已经被借走的书籍
            BookList.RemoveAll(book => book.SIG == true);

            SqlConnection con = SqlConnect.getConn();
            SqlCommandBuilder sqlBuilderda = new SqlCommandBuilder(da);

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
                    string SelectText = "select L_Id,B_Id,B_Name from V_Book where L_Id = " + "'" + BookList[i].ID + "'";
                    //定义创建sqlcommand并赋值给da
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SelectText;
                    cmd.Connection = con;
                    da.SelectCommand = cmd;

            
                    //if (!DS.Tables.Contains("Rowtemp"))//判断是否有表
                    //{
                    //    DataTable bookTable = new DataTable("Rowtemp");
                    //    DS.Tables.Add(bookTable);
                    //}
                    //else
                    //    DS.Tables["Rowtemp"].Clear();

                    con.Open();
                    //获取一本书
                    //da.Fill(DS, "Rowtemp");
                    da.Fill(DS, "books");
                    con.Close();

                    //DataRow row = DS.Tables["Rowtemp"].Rows[0];
                    //将这一行添加到books里
                    //DS.Tables["books"].Rows.Add(row);
                }

                //将读到绑定到GridView上
                GridView_Borrow.AutoGenerateColumns = false;
                //设置列的对应关系
                GridView_Borrow.Columns["Col1_BookName"].DataPropertyName = "B_Name";
                GridView_Borrow.Columns["Col1_Label"].DataPropertyName = "L_Id";
                GridView_Borrow.Columns["Col1_BookId"].DataPropertyName = "B_Id";
             
                GridView_Borrow.DataSource = DS;
                GridView_Borrow.DataMember = "books";

                for (int i = 0; i < GridView_Borrow.Rows.Count; i++)
                {
                    GridView_Borrow.Rows[i].Cells["Col1_Time"].Value = "30天";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("读取书籍失败!");
                return ;
            }
            finally
            {
                con.Close();
            }

        }
        
        //提交按钮
        private void Submmit_Click(object sender, EventArgs e)
        {
            //先写卡
            RFIDReader rFIDReader = new RFIDReader();
            for (int i = 0; i < BookList.Count(); i++)
            {
                BookList[i].SIG = true;
            }
            rFIDReader.SetReader(BookList);

            //再写数据库
            //取值
            string userId = pId;
            string bookId;
            string labelId;
            string date = DateTime.Now.ToString();
            int Time = 30;
            int isReturn = 0;

            //新建连接对象
            SqlConnection conn =SqlConnect.getConn();
            //拼接命令字符串

            for (int i = 0; i < GridView_Borrow.Rows.Count; i++)
            {
                labelId = GridView_Borrow.Rows[i].Cells["Col1_Label"].Value.ToString();
                bookId = GridView_Borrow.Rows[i].Cells["Col1_BookId"].Value.ToString();

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into T_Borrow(P_Id,L_Id,B_Id,BR_Start,BR_Time,BR_IsReturn) values ('" + userId + "','" + labelId + "','" + bookId + "','" + date+ "'," + Time+ "," + isReturn.ToString() + ")";
                    //MessageBox.Show(cmd.CommandText); //for test
                    int num1 = cmd.ExecuteNonQuery();

                    if (num1 > 0)
                        Console.WriteLine("入库成功！");
                    else
                        Console.WriteLine("系统故障，入库失败！");
                }
                catch
                {
                    Console.WriteLine("插入失败，请检测输入是否合法！");
                }
                finally
                {
                    if (conn != null)
                        conn.Close();
                }
            }


            MessageBox.Show("借阅成功!点击退出登录!");
            //返回主界面
            main.ReturnMainWin();

        }

       
    }
}
