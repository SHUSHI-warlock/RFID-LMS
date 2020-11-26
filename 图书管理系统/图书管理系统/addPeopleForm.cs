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
    public partial class addPeopleForm : Form
    {
        public addPeopleForm()
        {
            InitializeComponent();
        }

        private void bt_people_add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SqlConnect.getConn();
            try
            {
                string sql = "insert into T_People([P_Id],[P_Name],[P_Password]) values('{0}', '{1}', '{2}');";
                //填充占位符
                sql = string.Format(sql, tb_people_id.Text.Trim(), tb_people_name.Text.Trim(), tb_people_password.Text.Trim());
                //创建SqlCommand类的对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                //执行修改操作的SQL
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功！");
                //设置当前窗体DislogResult结果为OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
