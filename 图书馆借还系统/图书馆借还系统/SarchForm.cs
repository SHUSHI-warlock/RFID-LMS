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
    public partial class SarchForm : Form
    {
        Main main;
        string pId;
        string userName;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet DS = new DataSet();

        public SarchForm(Main MainWin)
        {
            main = MainWin;
            InitializeComponent();
        }

        public void ShowMyWin(string UserId)
        {
            this.Visible = true;
            pId = UserId;
            DS.Clear();
            label_Now.Text =  "0本";
            label_Timeout.Text = "0本";
            label_Name.Text = "XXX您好!";
            GridViewShow();
        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            main.ReturnMainWin();
        }

        private void GridViewShow()
        {
            SqlConnection con = SqlConnect.getConn();
            string SelectText;
            try
            {
                //创建查询语句
                SelectText = "select P_Name from T_People where P_Id = '" + pId + "'";
                //定义创建sqlcommand并赋值给da
                SqlCommand cmdName = new SqlCommand();
                cmdName.CommandText = SelectText;
                cmdName.Connection = con;
                da.SelectCommand = cmdName;

                con.Open();
                da.Fill(DS, "name");
                con.Close();

                if (DS.Tables["name"].Rows.Count==0)
                    throw new Exception("没有这人名字...");
                label_Name.Text = DS.Tables["name"].Rows[0][0].ToString()+"您好!";

                    //创建查询语句
                SelectText = "select * from V_Return where P_Id = '" + pId + "'";
                //定义创建sqlcommand并赋值给da
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SelectText;
                cmd.Connection = con;
                da.SelectCommand = cmd;

                con.Open();
                da.Fill(DS, "books");
                con.Close();


                //将读到绑定到GridView上
                GridView_Sch.AutoGenerateColumns = false;
                //设置列的对应关系
                GridView_Sch.Columns["Col_BookName"].DataPropertyName = "B_Name";
                GridView_Sch.Columns["Col_BookId"].DataPropertyName = "B_Id";
                GridView_Sch.Columns["Col_Reader"].DataPropertyName = "P_Id";
                GridView_Sch.Columns["Col_ReadDay"].DataPropertyName = "BR_Time";

                //GridView_Return.Columns["Col1_Start"].DataPropertyName = "BR_Start";

                //绑定
                GridView_Sch.DataSource = DS;
                GridView_Sch.DataMember = "books";

                DateTime dateTime = DateTime.Now;
                DateTime startTime;
                DateTime deadlineTime;

                int nowBook=0;
                int timeoutBook=0;

                for (int i = 0; i < GridView_Sch.Rows.Count; i++)
                {
                    startTime = (DateTime)DS.Tables["books"].Rows[i]["BR_Start"];
                    deadlineTime = startTime.AddDays(30);

                    GridView_Sch.Rows[i].Cells["Col_Deadline"].Value = deadlineTime.ToString();
                    GridView_Sch.Rows[i].Cells["Col_Start"].Value = startTime.ToString();

                    if ((int)DS.Tables["books"].Rows[i]["BR_Isreturn"] == 1)
                        GridView_Sch.Rows[i].Cells["Col_Status"].Value = "已归还";
                    else
                    {
                        if (dateTime.CompareTo(deadlineTime) > 0)
                        {
                            GridView_Sch.Rows[i].Cells["Col_Status"].Value = "已超时";
                            timeoutBook += 1;
                            nowBook += 1;
                        }
                        else
                        {
                            GridView_Sch.Rows[i].Cells["Col_Status"].Value = "借阅中";
                            nowBook += 1;
                        }
                    }
                }

                //显示当前借书
                label_Now.Text = nowBook.ToString()+"本";
                label_Timeout.Text = timeoutBook.ToString()+"本";



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
     

        
    }
}
