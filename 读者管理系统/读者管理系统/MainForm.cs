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
            //SqlConnection con = SqlConnect.getConn();
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

        private void GV_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QueryAllCourse()
        {
            SqlConnection conn = SqlConnect.getConn();
            try
            {
               
                //打开数据库
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
                    //关闭数据库连接
                    conn.Close();
                }
            }
        }


        private void bt_searchReader_Click(object sender, EventArgs e)
        {
            QueryAllCourse();
        }

        private void bt_addReader_Click(object sender, EventArgs e)
        {

        }

        private void bt_delReader_Click(object sender, EventArgs e)
        {
            SqlConnection con = SqlConnect.getConn();
            string insertionStr = "insert into T_People([P_Id],[P_Name],[P_Password]) values('5','5号','555');";
            SqlCommand command = con.CreateCommand();//绑定对象
            command.CommandText = insertionStr;
            con.Open();
            //command.ExecuteNonQuery();
            Console.WriteLine(command.ExecuteNonQuery());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
