﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书馆借还系统
{
    public partial class ReturnForm : Form
    {
        Main main;

        public ReturnForm(Main MainWin)
        {
            main = MainWin;
            InitializeComponent();
        }

        public void ShowMyWin()
        {
            this.Visible = true;
        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            main.ReturnMainWin();
        }

       
    }
}
