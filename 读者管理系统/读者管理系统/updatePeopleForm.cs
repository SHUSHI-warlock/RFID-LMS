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
    public partial class updatePeopleForm : Form
    {
        //修改窗体类的构造函数
        public updatePeopleForm(string people_id, string people_name, string people_password)
        {
            InitializeComponent();
            tb_people_id.Text = people_id;
            tb_people_name.Text = people_name;
            tb_people_password.Text = people_password;
        }

        private void bt_people_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SqlConnect.getConn();
            try
            {
                conn.Open();
                string sql = "update T_People set P_Name='{0}',P_Password='{1}'  where P_Id = '{2}';";
                //填充占位符
                sql = string.Format(sql, tb_people_name.Text.Trim(), tb_people_password.Text.Trim(), tb_people_id.Text.Trim());
                //创建SqlCommand类的对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                //执行修改操作的SQL
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功！");
                //设置当前窗体DislogResult结果为OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失败！" + ex.Message);
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
