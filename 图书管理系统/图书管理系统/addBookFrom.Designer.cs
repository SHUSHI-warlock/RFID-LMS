namespace 图书管理系统
{
    partial class addBookFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_addbook = new System.Windows.Forms.Panel();
            this.bt_out_RK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_bookin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_tagtext = new System.Windows.Forms.TextBox();
            this.bt_readtag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_bookname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_class = new System.Windows.Forms.ComboBox();
            this.tb_bookid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pl_addbook.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_addbook
            // 
            this.pl_addbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_addbook.Controls.Add(this.bt_out_RK);
            this.pl_addbook.Controls.Add(this.label1);
            this.pl_addbook.Controls.Add(this.bt_bookin);
            this.pl_addbook.Controls.Add(this.groupBox2);
            this.pl_addbook.Controls.Add(this.groupBox1);
            this.pl_addbook.Location = new System.Drawing.Point(12, 12);
            this.pl_addbook.Name = "pl_addbook";
            this.pl_addbook.Size = new System.Drawing.Size(400, 365);
            this.pl_addbook.TabIndex = 1;
            // 
            // bt_out_RK
            // 
            this.bt_out_RK.Location = new System.Drawing.Point(216, 313);
            this.bt_out_RK.Name = "bt_out_RK";
            this.bt_out_RK.Size = new System.Drawing.Size(85, 37);
            this.bt_out_RK.TabIndex = 15;
            this.bt_out_RK.Text = "返回";
            this.bt_out_RK.UseVisualStyleBackColor = true;
            this.bt_out_RK.Click += new System.EventHandler(this.bt_out_RK_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "图书入库";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_bookin
            // 
            this.bt_bookin.AutoSize = true;
            this.bt_bookin.Location = new System.Drawing.Point(83, 313);
            this.bt_bookin.Name = "bt_bookin";
            this.bt_bookin.Size = new System.Drawing.Size(85, 37);
            this.bt_bookin.TabIndex = 13;
            this.bt_bookin.Text = "添加入库";
            this.bt_bookin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_tagtext);
            this.groupBox2.Controls.Add(this.bt_readtag);
            this.groupBox2.Location = new System.Drawing.Point(9, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 58);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读取标签";
            // 
            // tb_tagtext
            // 
            this.tb_tagtext.Location = new System.Drawing.Point(107, 24);
            this.tb_tagtext.Name = "tb_tagtext";
            this.tb_tagtext.Size = new System.Drawing.Size(197, 25);
            this.tb_tagtext.TabIndex = 1;
            // 
            // bt_readtag
            // 
            this.bt_readtag.Location = new System.Drawing.Point(26, 24);
            this.bt_readtag.Name = "bt_readtag";
            this.bt_readtag.Size = new System.Drawing.Size(75, 23);
            this.bt_readtag.TabIndex = 0;
            this.bt_readtag.Text = "读取标签";
            this.bt_readtag.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_author);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_bookname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbb_class);
            this.groupBox1.Controls.Add(this.tb_bookid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "填写图书信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "书号：";
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(86, 91);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(100, 25);
            this.tb_author.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "书名：";
            // 
            // tb_bookname
            // 
            this.tb_bookname.Location = new System.Drawing.Point(86, 59);
            this.tb_bookname.Name = "tb_bookname";
            this.tb_bookname.Size = new System.Drawing.Size(100, 25);
            this.tb_bookname.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "作者：";
            // 
            // cbb_class
            // 
            this.cbb_class.FormattingEnabled = true;
            this.cbb_class.Items.AddRange(new object[] {
            "数学",
            "英语",
            "计算机"});
            this.cbb_class.Location = new System.Drawing.Point(86, 122);
            this.cbb_class.Name = "cbb_class";
            this.cbb_class.Size = new System.Drawing.Size(121, 23);
            this.cbb_class.TabIndex = 8;
            // 
            // tb_bookid
            // 
            this.tb_bookid.Location = new System.Drawing.Point(86, 28);
            this.tb_bookid.Name = "tb_bookid";
            this.tb_bookid.Size = new System.Drawing.Size(100, 25);
            this.tb_bookid.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "分类：";
            // 
            // addBookFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 385);
            this.Controls.Add(this.pl_addbook);
            this.Name = "addBookFrom";
            this.Text = "图书入库";
            this.Load += new System.EventHandler(this.addBookFrom_Load);
            this.pl_addbook.ResumeLayout(false);
            this.pl_addbook.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_addbook;
        private System.Windows.Forms.Button bt_out_RK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_bookin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_tagtext;
        private System.Windows.Forms.Button bt_readtag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_bookname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_class;
        private System.Windows.Forms.TextBox tb_bookid;
        private System.Windows.Forms.Label label5;
    }
}