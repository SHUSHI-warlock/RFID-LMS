using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace 图书馆借还系统
{
    public partial class LoginFrom : Form
    {
        Main main;
        string nextP;
        
        public LoginFrom(Main MainWin)
        {
            main = MainWin;
            InitializeComponent();
        }

        public void ShowMyWin(string NextPage)
        {
            this.Visible = true;
            nextP = NextPage;
            UserID.Text = "";
            UserPa.Text = "";
        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            main.ReturnMainWin();
        }
        //验证
        private bool Verification()
        {
            SqlConnection con = SqlConnect.getConn();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM T_People WHERE P_Id = @id and P_Password = @key", con);
                SqlParameter ID = new SqlParameter("@id", SqlDbType.VarChar, 20);
                ID.Value = UserID.Text;
                cmd.Parameters.Add(ID);
                SqlParameter KEY = new SqlParameter("@key", SqlDbType.VarChar, 20);
                KEY.Value = UserPa.Text;
                cmd.Parameters.Add(KEY);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                DA.Fill(Ds, "ReaderLogin");

                if (Ds.Tables["ReaderLogin"].Rows.Count == 0)
                {
                    MessageBox.Show("用户名或密码不正确!");
                    return false;
                }
                DataRow r = Ds.Tables["ReaderLogin"].Rows[0];
                MessageBox.Show("登录成功!\n欢迎:"+r["P_Name"].ToString());
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                MessageBox.Show("数据库连接失败!\n请与前台工作人员联系");
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        
        private void Login_Click(object sender, EventArgs e)
        {
            //验证是否正确
            if(Verification())
                main.Enter2Win(nextP, userid: UserID.Text);
        }

        
    }
}
