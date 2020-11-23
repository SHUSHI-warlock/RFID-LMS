using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书馆借还系统
{
    public partial class BorrowForm : Form
    {
        Main main;
        string pId = "";

        public BorrowForm(Main MainWin)
        {
            main = MainWin;
            InitializeComponent();
        }

        public void ShowMyWin(string UserId)
        {
            this.Visible = true;  
            pId = UserId;
        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            main.ReturnMainWin();
        }

        
    }
}
