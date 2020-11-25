namespace 图书管理系统
{
    partial class delBookForm
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
            this.pl_delbook = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_tagtext = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_out_CK = new System.Windows.Forms.Button();
            this.bt_bookout = new System.Windows.Forms.Button();
            this.pl_delbook.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_delbook
            // 
            this.pl_delbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_delbook.Controls.Add(this.label9);
            this.pl_delbook.Controls.Add(this.groupBox3);
            this.pl_delbook.Controls.Add(this.bt_out_CK);
            this.pl_delbook.Controls.Add(this.bt_bookout);
            this.pl_delbook.Location = new System.Drawing.Point(12, 12);
            this.pl_delbook.Name = "pl_delbook";
            this.pl_delbook.Size = new System.Drawing.Size(450, 239);
            this.pl_delbook.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(448, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "图书出库";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_tagtext);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(35, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 80);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "读取标签";
            // 
            // tb_tagtext
            // 
            this.tb_tagtext.Location = new System.Drawing.Point(141, 33);
            this.tb_tagtext.Name = "tb_tagtext";
            this.tb_tagtext.Size = new System.Drawing.Size(221, 25);
            this.tb_tagtext.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 39);
            this.button3.TabIndex = 0;
            this.button3.Text = "读取标签";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_out_CK
            // 
            this.bt_out_CK.Location = new System.Drawing.Point(240, 162);
            this.bt_out_CK.Name = "bt_out_CK";
            this.bt_out_CK.Size = new System.Drawing.Size(108, 55);
            this.bt_out_CK.TabIndex = 16;
            this.bt_out_CK.Text = "返回";
            this.bt_out_CK.UseVisualStyleBackColor = true;
            this.bt_out_CK.Click += new System.EventHandler(this.bt_out_CK_Click);
            // 
            // bt_bookout
            // 
            this.bt_bookout.AutoSize = true;
            this.bt_bookout.Location = new System.Drawing.Point(102, 162);
            this.bt_bookout.Name = "bt_bookout";
            this.bt_bookout.Size = new System.Drawing.Size(108, 55);
            this.bt_bookout.TabIndex = 16;
            this.bt_bookout.Text = "图书出库";
            this.bt_bookout.UseVisualStyleBackColor = true;
            this.bt_bookout.Click += new System.EventHandler(this.bt_bookout_Click);
            // 
            // delBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 263);
            this.Controls.Add(this.pl_delbook);
            this.Name = "delBookForm";
            this.Text = "图书出库";
            this.Load += new System.EventHandler(this.delBookForm_Load);
            this.pl_delbook.ResumeLayout(false);
            this.pl_delbook.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_delbook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_tagtext;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_out_CK;
        private System.Windows.Forms.Button bt_bookout;
    }
}