using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class MainForm : Form
    {
        //构造
        public MainForm()
        {
            InitializeComponent();
        }

        //MainForm加载
        #region
            private void MainForm_Load(object sender, EventArgs e)
            {
                this.cb_class.SelectedIndex = -1;
                this.tb_author.Text = null;
                this.tb_BookName.Text = null;
            }
        #endregion

        //图书信息管理
        #region
        //图书入库按钮函数
            private void bt_addbook_Click(object sender, EventArgs e)
            {
                //点击打开图书入库页面
                addBookFrom adf = new addBookFrom();
                adf.ShowDialog();

            }
            //图书出库按钮函数
            private void bt_delbook_Click(object sender, EventArgs e)
            {
                //点击打开图书出库页面
                delBookForm adf = new delBookForm();
                adf.ShowDialog();
            }
            //图书信息查询按钮函数
            private void bt_searchbook_Click(object sender, EventArgs e)
            {
                SqlConnection conn = null;
                try
                {
                    conn = SqlConnect.getConn();
                    string strSQL = "select * from T_Book ";
                    if (this.tb_BookName.Text != String.Empty)
                    {
                        strSQL = strSQL + "where B_Name = " + "'" + this.tb_BookName.Text.ToString().Trim() + "'";
                        if (this.tb_author.Text != String.Empty)
                        {
                            strSQL = strSQL + "and B_Author = " + "'" + this.tb_author.Text.ToString().Trim() + "'";
                            if (this.cb_class.Text != String.Empty)
                            {
                                strSQL = strSQL + "and B_Class = " + "'" + this.cb_class.Text.ToString().Trim() + "'";
                            }
                        }
                        else
                        {
                            if (this.cb_class.Text != String.Empty)
                            {
                                strSQL = strSQL + "and B_Class = " + "'" + this.cb_class.Text.ToString().Trim() + "'";
                            }
                        }
                    }
                    else
                    {
                        if (this.tb_author.Text != String.Empty)
                        {
                            strSQL = strSQL + "where B_Author = " + "'" + this.tb_author.Text.ToString().Trim() + "'";
                            if (this.cb_class.Text != String.Empty)
                            {
                                strSQL = strSQL + "and B_Class = " + "'" + this.cb_class.Text.ToString().Trim() + "'";
                            }
                        }
                        else
                        {
                            if (this.cb_class.Text != String.Empty)
                            {
                                strSQL = strSQL + "where B_Class = " + "'" + this.cb_class.Text.ToString().Trim() + "'";
                            }
                        }
                    }
                    GridView_Books.AutoGenerateColumns = false;
                    DataSet dataSet = new DataSet();
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dataSet, "Books");
                    GridView_Books.Columns["Col1_BookId"].DataPropertyName = "B_Id";
                    GridView_Books.Columns["Col1_BookName"].DataPropertyName = "B_Name";
                    GridView_Books.Columns["Col1_Author"].DataPropertyName = "B_Author";
                    GridView_Books.Columns["Col1_Class"].DataPropertyName = "B_Class";
                    GridView_Books.Columns["Col1_AllNum"].DataPropertyName = "B_CountAll";
                    GridView_Books.Columns["Col1_NowNum"].DataPropertyName = "B_CountNow";
                    GridView_Books.DataSource = dataSet;
                    GridView_Books.DataMember = "Books";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "未知错误");
                }
                finally
                {
                    conn.Close();
                }

            }
        #endregion

        //借阅信息管理
        #region
        //借阅信息查询按钮点击函数
            private void bt_Search_Click(object sender, EventArgs e)
            {
                SqlConnection conn = null;
                try
                {
                    conn = SqlConnect.getConn();
                    string strSQL = "select * from T_Borrow ";
                    bool nowNull = true;
                    if (this.tb_Pid.Text != String.Empty)
                    {
                        if(!nowNull)
                        {
                            strSQL = strSQL + "and ";
                        }
                        else
                        {
                            strSQL = strSQL + "where ";
                        }
                        strSQL = strSQL + "P_Id = " + "'" + this.tb_Pid.Text.ToString().Trim() + "'";
                        nowNull = false;
                    }
                    if (this.tb_Bid.Text != String.Empty)
                    {
                        if (!nowNull)
                        {
                            strSQL = strSQL + "and ";
                        }
                        else
                        {
                            strSQL = strSQL + "where ";
                        }
                        strSQL = strSQL + "B_Id = " + "'" + this.tb_Bid.Text.ToString().Trim() + "'";
                        nowNull = false;
                    }
                    if (this.cb_states.Text != String.Empty)
                    {
                        if (!nowNull)
                        {
                            strSQL = strSQL + "and ";
                        }
                        else
                        {
                            strSQL = strSQL + "where ";
                        }
                        if (this.cb_states.Text.ToString().Equals("已归还"))
                        {
                            strSQL = strSQL + "BR_IsReturn = 1";
                        }
                        else if (this.cb_states.Text.ToString().Equals("借阅中"))
                        {
                            strSQL = strSQL + "BR_IsReturn = 0";
                        }
                        else if (this.cb_states.Text.ToString().Equals("已超时"))
                        {
                            DateTime dateTime = DateTime.Now;
                            DateTime beginTime = dateTime.AddDays(-30);
                            strSQL = strSQL + "datediff(dd, " + "BR_Start, " + "'" + beginTime.ToString().Trim() + "'" + " ) >0";
                        }
                        nowNull = false;
                    }
                    if (this.tb_time.Text != String.Empty)
                    {
                        if (!nowNull)
                        {
                            strSQL = strSQL + "and ";
                        }
                        else
                        {
                            strSQL = strSQL + "where ";
                        }
                        string strTime = this.tb_time.Text;
                        DateTime dateTime = DateTime.Parse(strTime);
                        strTime = string.Format("{0:d}", dateTime);
                        strSQL = strSQL + "datediff(dd, BR_Start, " + "'" + strTime.ToString() + "'" + ") = 0 ";
                        nowNull = false;
                    }
                    Console.WriteLine(strSQL);
                    GridView_Borrow.AutoGenerateColumns = false;
                    DataSet dataSet = new DataSet();
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dataSet, "Borrows");
                    GridView_Borrow.Columns["Col_ReaderID"].DataPropertyName = "P_Id";
                    GridView_Borrow.Columns["Col_BookId2"].DataPropertyName = "B_Id";
                    GridView_Borrow.Columns["Col3_StartDay"].DataPropertyName = "BR_Start";
                    GridView_Borrow.DataSource = dataSet;
                    GridView_Borrow.DataMember = "Borrows";
                    for (int i = 0; i < GridView_Borrow.Rows.Count; i++)
                    {
                        DateTime startTime = (DateTime)dataSet.Tables["Borrows"].Rows[i]["BR_Start"];
                        DateTime deadlineTime = startTime.AddDays(30);
                        GridView_Borrow.Rows[i].Cells["Col3_Deadline"].Value = deadlineTime.ToString();
                        if ((int)dataSet.Tables["Borrows"].Rows[i]["BR_IsReturn"] == 1)
                        {
                            GridView_Borrow.Rows[i].Cells["Col3_ReadDay"].Value = dataSet.Tables["Borrows"].Rows[i]["BR_Time"].ToString();
                            GridView_Borrow.Rows[i].Cells["Col_IsReturn"].Value = "已归还";
                        }
                        else
                        {
                            DateTime nowTime = DateTime.Now;
                            int readTime = new TimeSpan(nowTime.Ticks - startTime.Ticks).Days;
                            GridView_Borrow.Rows[i].Cells["Col3_ReadDay"].Value = readTime.ToString();
                            if (nowTime.CompareTo(deadlineTime) > 0)
                            {
                                GridView_Borrow.Rows[i].Cells["Col_IsReturn"].Value = "已超时";
                            }
                            else
                            {
                                GridView_Borrow.Rows[i].Cells["Col_IsReturn"].Value = "借阅中";
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "未知错误");
                }
                finally
                {
                    conn.Close();
                }
             }
            //时间清空按钮点击函数
            private void bt_Null_Click(object sender, EventArgs e)
            {
                this.tb_time.Text = String.Empty;
            }
            //时间选择内容变化函数
            private void dateTimePicker_ValueChanged(object sender, EventArgs e)
            {
                this.tb_time.Text = this.dateTimePicker.Text;
            }
        #endregion
    }
}