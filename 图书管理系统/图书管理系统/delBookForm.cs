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
    public partial class delBookForm : Form
    {
        public delBookForm()
        {
            InitializeComponent();
        }
        //加载函数
        private void delBookForm_Load(object sender, EventArgs e)
        {
            this.tb_tagtext.Text = String.Empty;
        }
        //返回按钮函数
        private void bt_out_CK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //图书出库按钮函数
        private void bt_bookout_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = SqlConnect.getConn();
                string B_Id = null;
                string strSQL = @"select * from T_Label where L_Id =" + "'" + this.tb_tagtext.Text.ToString().Trim() + "'";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                        B_Id = sqlDataReader[0].ToString().Trim();
                    sqlDataReader.Close();
                    strSQL = @"update T_Book "
                                        + "set B_CountAll -= 1,"
                                        + "B_CountNow -= 1"
                                        + "where B_Id = '" + B_Id + "'";
                    cmd.CommandText = strSQL;
                    int updateBookNum = cmd.ExecuteNonQuery();
                    strSQL = @"delete from T_Label where B_Id = " + "'" + B_Id + "'"
                                            + " and "
                                            + "L_Id = '" + this.tb_tagtext.Text.ToString().Trim() + "'";
                    cmd.CommandText = strSQL;
                    int deleteLabelNum = cmd.ExecuteNonQuery();
                    if ((updateBookNum == 1) && (deleteLabelNum == 1))
                    {
                        MessageBox.Show("书号为：" + B_Id.Trim() +
                                                        " 标签号为：" + this.tb_tagtext.Text.ToString().Trim() +
                                                        " 的书已出库！", "出库成功");
                        this.tb_tagtext.Text = String.Empty;
                    }
                    else
                    {
                        throw new Exception("入库失败！");
                    }
                }
                else
                {
                    sqlDataReader.Close();
                    this.tb_tagtext.Text = String.Empty;
                    MessageBox.Show("不存在此标签号！", "标签号错误");
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
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
