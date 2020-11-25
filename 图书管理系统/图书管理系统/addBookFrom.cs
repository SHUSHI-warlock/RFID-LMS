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
    public partial class addBookFrom : Form
    {
        public addBookFrom()
        {
            InitializeComponent();
        }
        //加载函数
        private void addBookFrom_Load(object sender, EventArgs e)
        {
            this.tb_author.Text = String.Empty;
            this.tb_bookid.Text = String.Empty;
            this.tb_bookname.Text = String.Empty;
            this.tb_tagtext.Text = String.Empty;
            this.cbb_class.SelectedIndex = -1;
        }
        //返回按钮函数
        private void bt_out_RK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //添加入库按钮函数
        private void bt_bookin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = SqlConnect.getConn();
                string strSQL = @"select * from T_Label where L_Id =" + "'" + this.tb_tagtext.Text.ToString().Trim() + "'";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                //标签号重复
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Close();
                    MessageBox.Show("入库失败！此标签号已存在", "旧书入库失败");
                }
                //标签号不重复
                else
                {
                    sqlDataReader.Close();
                    strSQL = @"select * from T_Book where B_Id = " + "'" + this.tb_bookid.Text.ToString().Trim() + "'";
                    cmd = new SqlCommand(strSQL, conn);
                    sqlDataReader = cmd.ExecuteReader();
                    //旧书入库
                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Close();
                        //UPDATE 表名称 SET 列名称 = 新值 WHERE 列名称 = 某值
                        strSQL = @"update T_Book "
                                           + "set B_CountAll += 1,"
                                           + "B_CountNow += 1"
                                           + "where B_Id = '" + this.tb_bookid.Text.ToString().Trim() + "'";
                        cmd.CommandText = strSQL;
                        int updateNum = cmd.ExecuteNonQuery();
                        strSQL = @"insert into T_Label "
                                      + "values("
                                      + "'" + this.tb_bookid.Text.ToString().Trim() + "'" + ","
                                      + "'" + this.tb_tagtext.Text.ToString().Trim() + "'"
                                      + ")";
                        cmd.CommandText = strSQL;
                        int insertLabelNum = cmd.ExecuteNonQuery();
                        if ((updateNum == 1) && (insertLabelNum == 1))
                        {
                            MessageBox.Show("书号为：" + this.tb_bookid.Text.ToString().Trim() +
                                                        " 标签号为：" + this.tb_tagtext.Text.ToString().Trim() +
                                                        " 的书已入库！", "已有图书入库成功");
                            this.tb_author.Text = String.Empty;
                            this.tb_bookid.Text = String.Empty;
                            this.tb_bookname.Text = String.Empty;
                            this.tb_tagtext.Text = String.Empty;
                            this.cbb_class.SelectedIndex = -1;
                        }
                        else
                        {
                            throw new Exception("入库失败！");
                        }
                    }
                    //新书入库
                    else
                    {
                        sqlDataReader.Close();
                        //INSERT INTO 表名称 VALUES (值1, 值2,....)
                        strSQL = @"insert into T_Book "
                                           + "values("
                                           + "'" + this.tb_bookid.Text.ToString().Trim() + "'" + ","
                                           + "'" + this.cbb_class.Text.ToString().Trim() + "'" + ","
                                           + "'" + this.tb_author.Text.ToString().Trim() + "'" + ","
                                           + "'" + this.tb_bookname.Text.ToString().Trim() + "'" + ","
                                           + " '1' , '1' )";
                        cmd.CommandText = strSQL;
                        int insertBookNum = cmd.ExecuteNonQuery();
                        strSQL = @"insert into T_Label "
                                          + "values("
                                          + "'" + this.tb_bookid.Text.ToString().Trim() + "'" + ","
                                          + "'" + this.tb_tagtext.Text.ToString().Trim() + "'"
                                          + ")";
                        cmd.CommandText = strSQL;
                        int insertLabelNum = cmd.ExecuteNonQuery();
                        if ((insertBookNum == 1) && (insertLabelNum == 1))
                        {
                            MessageBox.Show("书号为：" + this.tb_bookid.Text.ToString().Trim() +
                                                        " 标签号为：" + this.tb_tagtext.Text.ToString().Trim() +
                                                        " 的书已入库！", "新增图书入库成功");
                            this.tb_author.Text = String.Empty;
                            this.tb_bookid.Text = String.Empty;
                            this.tb_bookname.Text = String.Empty;
                            this.tb_tagtext.Text = String.Empty;
                            this.cbb_class.SelectedIndex = -1;
                        }
                        else
                        {
                            throw new Exception("入库失败！");
                        }
                    }
                }
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
        //读取标签按钮
        private void bt_readtag_Click(object sender, EventArgs e)
        {

        }

        private void tb_bookid_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = SqlConnect.getConn();
                string strSQL = @"select * from T_Book where B_Id = " + "'" + this.tb_bookid.Text.ToString().Trim() + "'";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        this.cbb_class.Text = sqlDataReader[1].ToString().Trim();
                        this.tb_author.Text = sqlDataReader[2].ToString().Trim();
                        this.tb_bookname.Text = sqlDataReader[3].ToString().Trim();
                    }
                }
                else
                {
                    this.cbb_class.Text = String.Empty;
                    this.tb_author.Text = String.Empty;
                    this.tb_bookname.Text = String.Empty;
                }
                sqlDataReader.Close();
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
    }
}
