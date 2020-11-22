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
    public partial class delBookForm : Form
    {
        public delBookForm()
        {
            InitializeComponent();
        }

        private void bt_out_CK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
