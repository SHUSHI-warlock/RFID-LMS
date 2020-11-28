namespace 图书馆借还系统
{
    partial class Main
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
            this.button_B = new System.Windows.Forms.Button();
            this.button_R = new System.Windows.Forms.Button();
            this.button_S = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_B
            // 
            this.button_B.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_B.Location = new System.Drawing.Point(111, 251);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(200, 200);
            this.button_B.TabIndex = 0;
            this.button_B.Text = "借书";
            this.button_B.UseVisualStyleBackColor = true;
            this.button_B.Click += new System.EventHandler(this.button_B_Click);
            // 
            // button_R
            // 
            this.button_R.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_R.Location = new System.Drawing.Point(415, 251);
            this.button_R.Name = "button_R";
            this.button_R.Size = new System.Drawing.Size(200, 200);
            this.button_R.TabIndex = 1;
            this.button_R.Text = "还书";
            this.button_R.UseVisualStyleBackColor = true;
            this.button_R.Click += new System.EventHandler(this.button_R_Click);
            // 
            // button_S
            // 
            this.button_S.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_S.Location = new System.Drawing.Point(704, 251);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(237, 200);
            this.button_S.TabIndex = 2;
            this.button_S.Text = "查看借还记录";
            this.button_S.UseVisualStyleBackColor = true;
            this.button_S.Click += new System.EventHandler(this.button_S_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("华文行楷", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1062, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "                                  欢迎使用借阅系统";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_S);
            this.Controls.Add(this.button_R);
            this.Controls.Add(this.button_B);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Button button_R;
        private System.Windows.Forms.Button button_S;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}