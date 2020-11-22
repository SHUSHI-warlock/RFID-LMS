using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool Verification()
        {
            string name = this.Username.Text;
            string psw = this.Password.Text;

            /*if (name == "administrator" && psw == "000000")
                return true;
            else
                return false;
            */
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Verification())
            {
                MessageBox.Show("用户名或密码错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //生成MainForm
            MainForm anotherForm = new MainForm();
            //隐藏当前窗体
            this.Hide();
            //显示
            anotherForm.ShowDialog();
            //关闭当前进程
            Application.ExitThread();
        }
    }
}
