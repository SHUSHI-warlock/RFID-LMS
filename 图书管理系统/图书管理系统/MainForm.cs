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
            /*this.cb_class.SelectedIndex = -1;
             this.tb_author.Text = null;
             this.tb_BookName.Text = null;*/
        }

        //图书入库
        #region
        //点击打开图书入库页面
        private void bt_addbook_Click(object sender, EventArgs e)
        {
            //打开入库窗口
            addBookFrom adf = new addBookFrom();
            adf.ShowDialog();

        }
        #endregion

        //图书出库按钮
        #region
        //点击打开图书入库页面
        private void bt_delbook_Click(object sender, EventArgs e)
        {
            delBookForm adf = new delBookForm();
            adf.ShowDialog();
        }
        #endregion

        //初始化
        #region
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.cb_class.SelectedIndex = -1;
            this.tb_author.Text = null;
            this.tb_BookName.Text = null;
        }
        #endregion

        //查询按钮
        #region
        private void bt_searchbook_Click(object sender, EventArgs e)
        {
            SqlConnection conn=null;
            try
            {
                conn = SqlConnect.getConn();
                string strSQL = "select * from T_Book ";
                if (this.tb_BookName.Text != String.Empty)
                {
                    strSQL = strSQL + "where B_Name = " + "'" + this.tb_BookName.Text.ToString().Trim() + "'";
                    if(this.tb_author.Text != String.Empty)
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
                sqlDataAdapter.Fill(dataSet, "T_Book");
                GridView_Books.Columns["Col1_BookId"].DataPropertyName = "B_Id";
                GridView_Books.Columns["Col1_BookName"].DataPropertyName = "B_Name";
                GridView_Books.Columns["Col1_Author"].DataPropertyName = "B_Author";
                GridView_Books.Columns["Col1_Class"].DataPropertyName = "B_Class";
                GridView_Books.Columns["Col1_AllNum"].DataPropertyName = "B_CountAll";
                GridView_Books.Columns["Col1_NowNum"].DataPropertyName = "B_CountNow";
                GridView_Books.DataSource = dataSet;
                GridView_Books.DataMember = "T_Book";
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}