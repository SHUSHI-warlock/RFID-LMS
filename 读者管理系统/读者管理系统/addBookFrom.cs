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
    public partial class addBookFrom : Form
    {
        public addBookFrom()
        {
            InitializeComponent();
        }

        private void addBookFrom_Load(object sender, EventArgs e)
        {

        }
        //返回主界面
        private void bt_out_RK_Click(object sender, EventArgs e)
        {
            //关闭子窗口
            this.Close();
        }
        private void bt_bookin_Click(object sender, EventArgs e)
        {

        }

        private void bt_readtag_Click(object sender, EventArgs e)
        {

        }


        ///禁用 最小化 关闭 放大
        ///
        //这个可以禁止，但是不能去掉那三个图标
        /*
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x112)
            {
                switch ((int)m.WParam)
                {
                    //禁止双击标题栏关闭窗体
                    case 0xF063:
                    case 0xF093:
                        m.WParam = IntPtr.Zero;
                        break;

                    //禁止拖拽标题栏还原窗体
                    case 0xF012:
                    case 0xF010:
                        m.WParam = IntPtr.Zero;
                        break;

                    //禁止双击标题栏
                    case 0xf122:
                        m.WParam = IntPtr.Zero;
                        break;

                    //禁止关闭按钮
                    case 0xF060:
                        m.WParam = IntPtr.Zero;
                        break;

                    //禁止最大化按钮
                    case 0xf020:
                        m.WParam = IntPtr.Zero;
                        break;

                    //禁止最小化按钮
                    case 0xf030:
                        m.WParam = IntPtr.Zero;
                        break;

                    //禁止还原按钮
                    case 0xf120:
                        m.WParam = IntPtr.Zero;
                        break;
                }
            }
            base.WndProc(ref m);
        }
        */

    }
}
