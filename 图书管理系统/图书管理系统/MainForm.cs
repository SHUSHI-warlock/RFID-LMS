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

        //读者信息管理
        #region
        //查询所有读者信息函数
        private void QueryAllReader()
        {
            SqlConnection conn = SqlConnect.getConn();
            try
            {
                string sql = "select * from T_People";
                //创建SqlDataAdapter类的对象
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                //创建DataSet类的对象
                DataSet ds = new DataSet();
                //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                sda.Fill(ds);
                //设置表格控件的DataSource属性
                dataGridView1.DataSource = ds.Tables[0];

                //设置数据表格上显示的列标题
                dataGridView1.Columns[0].HeaderText = "读者ID";
                dataGridView1.Columns[1].HeaderText = "名字";
                dataGridView1.Columns[2].HeaderText = "密码";
                dataGridView1.Columns[0].Width = 125;
                dataGridView1.Columns[1].Width = 125;
                dataGridView1.Columns[2].Width = 125;
                dataGridView1.Columns[0].MinimumWidth = 6;
                dataGridView1.Columns[1].MinimumWidth = 6;
                dataGridView1.Columns[2].MinimumWidth = 6;
                //设置数据表格为只读
                dataGridView1.ReadOnly = true;
                //不允许添加行
                dataGridView1.AllowUserToAddRows = false;
                //背景为白色
                dataGridView1.BackgroundColor = Color.White;
                //只允许选中单行
                dataGridView1.MultiSelect = false;
                //整行选中
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询错误！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        //查询读者按钮函数
        private void bt_searchReader_Click_1(object sender, EventArgs e)
        {
            if (tb_readerid_input.Text.Trim() != "")
            {
                SqlConnection conn = SqlConnect.getConn();
                try
                {
                    string sql = "select * from T_People where P_Id= '{0}';";
                    //填充占位符
                    sql = string.Format(sql, tb_readerid_input.Text.Trim());
                    //创建SqlDataAdapter类的对象
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    //创建DataSet类的对象
                    DataSet ds = new DataSet();
                    //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                    sda.Fill(ds);
                    //设置表格控件的DataSource属性
                    dataGridView1.DataSource = ds.Tables[0];

                    //设置数据表格上显示的列标题
                    dataGridView1.Columns[0].HeaderText = "读者ID";
                    dataGridView1.Columns[1].HeaderText = "名字";
                    dataGridView1.Columns[2].HeaderText = "密码";
                    dataGridView1.Columns[0].Width = 125;
                    dataGridView1.Columns[1].Width = 125;
                    dataGridView1.Columns[2].Width = 125;
                    //设置数据表格为只读
                    dataGridView1.ReadOnly = true;
                    //不允许添加行
                    dataGridView1.AllowUserToAddRows = false;
                    //背景为白色
                    dataGridView1.BackgroundColor = Color.White;
                    //只允许选中单行
                    dataGridView1.MultiSelect = false;
                    //整行选中
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出现错误！" + ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                QueryAllReader();
            }
        }
        //添加读者按钮函数
        private void bt_addReader_Click_1(object sender, EventArgs e)
        {
            //创建updateForm类的对象，并将课程信息传递给修改界面
            addPeopleForm addPeople = new addPeopleForm();
            //弹出修改信息窗口
            DialogResult dr = addPeople.ShowDialog();
            //判断是否单击确定按钮
            if (dr == DialogResult.OK)
            {
                //调用查询全部读者方法
                QueryAllReader();
            }
        }
        //修改读者按钮函数
        private void bt_changeReader_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("没有可修改的记录！");
            }
            else
            {
                //未选中记录
                if (dataGridView1.SelectedRows.Count.Equals(0))
                {
                    MessageBox.Show("请选中要修改的记录！");
                    return;
                }
                //获取DataGridView控件中的值
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
                string password = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();

                updatePeopleForm updatePeople = new updatePeopleForm(id, name, password);
                //弹出修改信息窗口
                DialogResult dr = updatePeople.ShowDialog();
                //判断是否单击确定按钮
                if (dr == DialogResult.OK)
                {
                    QueryAllReader();
                }
            }
        }
        //删除读者按钮函数
        private void bt_delReader_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("没有可删除的记录！");
            }
            else
            {
                //未选中记录
                if (dataGridView1.SelectedRows.Count.Equals(0))
                {
                    MessageBox.Show("请选中要删除的记录！");
                    return;
                }
                //获取DataGridView控件中选中行的编号列的值
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                SqlConnection conn = SqlConnect.getConn();
                try
                {
                    string sql = "delete from T_People where P_Id='{0}'";
                    //填充占位符
                    sql = string.Format(sql, id);
                    //创建SqlCommand类的对象
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //执行SQL语句
                    cmd.ExecuteNonQuery();
                    //弹出消息提示删除成功
                    MessageBox.Show("删除成功！");
                    //调用查询全部的方法，刷新DataGridView控件中的数据
                    QueryAllReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除失败！" + ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        #endregion

    }
}