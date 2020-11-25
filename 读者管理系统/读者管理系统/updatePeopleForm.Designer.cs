namespace 图书管理系统
{
    partial class updatePeopleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_people_password = new System.Windows.Forms.TextBox();
            this.tb_people_name = new System.Windows.Forms.TextBox();
            this.tb_people_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_people_update = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改读者信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_people_password);
            this.groupBox1.Controls.Add(this.tb_people_name);
            this.groupBox1.Controls.Add(this.tb_people_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "填写修改信息";
            // 
            // tb_people_password
            // 
            this.tb_people_password.Location = new System.Drawing.Point(105, 154);
            this.tb_people_password.Name = "tb_people_password";
            this.tb_people_password.Size = new System.Drawing.Size(250, 27);
            this.tb_people_password.TabIndex = 5;
            // 
            // tb_people_name
            // 
            this.tb_people_name.Location = new System.Drawing.Point(105, 108);
            this.tb_people_name.Name = "tb_people_name";
            this.tb_people_name.Size = new System.Drawing.Size(250, 27);
            this.tb_people_name.TabIndex = 4;
            // 
            // tb_people_id
            // 
            this.tb_people_id.Location = new System.Drawing.Point(105, 55);
            this.tb_people_id.Name = "tb_people_id";
            this.tb_people_id.Size = new System.Drawing.Size(250, 27);
            this.tb_people_id.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "名字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "读者ID:";
            // 
            // bt_people_update
            // 
            this.bt_people_update.Font = new System.Drawing.Font("宋体", 10F);
            this.bt_people_update.Location = new System.Drawing.Point(50, 312);
            this.bt_people_update.Name = "bt_people_update";
            this.bt_people_update.Size = new System.Drawing.Size(136, 80);
            this.bt_people_update.TabIndex = 2;
            this.bt_people_update.Text = "确定修改";
            this.bt_people_update.UseVisualStyleBackColor = true;
            this.bt_people_update.Click += new System.EventHandler(this.bt_people_update_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("宋体", 10F);
            this.bt_cancel.Location = new System.Drawing.Point(293, 312);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(135, 80);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // updatePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 452);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_people_update);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "updatePeopleForm";
            this.Text = "修改读者";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_people_password;
        private System.Windows.Forms.TextBox tb_people_name;
        private System.Windows.Forms.TextBox tb_people_id;
        private System.Windows.Forms.Button bt_people_update;
        private System.Windows.Forms.Button bt_cancel;
    }
}