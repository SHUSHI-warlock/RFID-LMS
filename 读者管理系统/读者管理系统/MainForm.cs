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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            QueryAllReader();
        }
        /// <summary>
        /// 图书入库
        /// </summary>
        #region

        //点击打开图书入库页面
        private void bt_addbook_Click(object sender, EventArgs e)
        {
            //打开入库窗口
            addBookFrom adf = new addBookFrom();
            adf.ShowDialog();

        }
       
        #endregion

        /// <summary>
        /// 图书出库
        /// </summary>
        #region

        //点击打开图书入库页面
        private void bt_delbook_Click(object sender, EventArgs e)
        {
            delBookForm adf = new delBookForm();
            adf.ShowDialog();
        }


        #endregion

        //查询所有读者信息函数
        private void QueryAllReader()
        {
            SqlConnection conn = SqlConnect.getConn();
            try
            {
                conn.Open();
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
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "名字";
                dataGridView1.Columns[2].HeaderText = "密码";           
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

        /// <summary>
        /// 查询读者
        /// </summary>
        private void bt_searchReader_Click(object sender, EventArgs e)
        {
            if (tb_read_id.Text.Trim() != "")
            {
                SqlConnection conn = SqlConnect.getConn();
                try
                {
                    conn.Open();
                    string sql = "select * from T_People where P_Id= '{0}';";
                    //填充占位符
                    sql = string.Format(sql, tb_read_id.Text.Trim());
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
        }

        /// <summary>
        /// 添加读者
        /// </summary>
        private void bt_addReader_Click(object sender, EventArgs e)
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

        /// <summary>
        /// 删除读者
        /// </summary>
        private void bt_delReader_Click(object sender, EventArgs e)
        {
            //获取DataGridView控件中选中行的编号列的值
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            SqlConnection conn = SqlConnect.getConn();
            try
            {
                conn.Open();
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

        /// <summary>
        /// 修改读者
        /// </summary>
        private void bt_changeReader_Click(object sender, EventArgs e)
        {
            //获取DataGridView控件中的值
            //获取读者ID
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
            //获取读者名字
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
            //获取读者密码
            string password = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();

            //创建updateForm类的对象，并将课程信息传递给修改界面
            updatePeopleForm updatePeople = new updatePeopleForm(id, name, password);
            //弹出修改信息窗口
            DialogResult dr = updatePeople.ShowDialog();
            //判断是否单击确定按钮
            if (dr == DialogResult.OK)
            {
                //调用查询全部读者方法
                QueryAllReader();
            }
        }
    }
}
