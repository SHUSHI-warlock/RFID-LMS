﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 图书入库
        /// </summary>
        #region

        //点击打开图书入库页面
        private void bt_addbook_Click(object sender, EventArgs e)
        {
            //打开入库窗口
            addBookFrom adf = new addBookFrom();
            adf.ShowDialog();

        }
        



        #endregion

        /// <summary>
        /// 图书出库
        /// </summary>
        #region

        //点击打开图书入库页面
        private void bt_delbook_Click(object sender, EventArgs e)
        {
            delBookForm adf = new delBookForm();
            adf.ShowDialog();
        }
       


        #endregion

      
    }
}
