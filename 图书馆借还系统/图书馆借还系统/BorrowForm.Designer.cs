namespace 图书馆借还系统
{
    partial class BorrowForm
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
            this.BookNum = new System.Windows.Forms.NumericUpDown();
            this.button_ReadInfo = new System.Windows.Forms.Button();
            this.GridView_Borrow = new System.Windows.Forms.DataGridView();
            this.Col1_BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submmit = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Borrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(120, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "本次借书本数:";
            // 
            // BookNum
            // 
            this.BookNum.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNum.Location = new System.Drawing.Point(320, 31);
            this.BookNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BookNum.Name = "BookNum";
            this.BookNum.Size = new System.Drawing.Size(143, 34);
            this.BookNum.TabIndex = 1;
            // 
            // button_ReadInfo
            // 
            this.button_ReadInfo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ReadInfo.Location = new System.Drawing.Point(744, 33);
            this.button_ReadInfo.Name = "button_ReadInfo";
            this.button_ReadInfo.Size = new System.Drawing.Size(202, 68);
            this.button_ReadInfo.TabIndex = 2;
            this.button_ReadInfo.Text = "读取书籍信息";
            this.button_ReadInfo.UseVisualStyleBackColor = true;
            this.button_ReadInfo.Click += new System.EventHandler(this.button_ReadInfo_Click);
            // 
            // GridView_Borrow
            // 
            this.GridView_Borrow.AllowUserToAddRows = false;
            this.GridView_Borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Borrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1_BookName,
            this.Col1_Label,
            this.Col1_BookId,
            this.Col1_Time});
            this.GridView_Borrow.Location = new System.Drawing.Point(125, 144);
            this.GridView_Borrow.Name = "GridView_Borrow";
            this.GridView_Borrow.ReadOnly = true;
            this.GridView_Borrow.RowTemplate.Height = 27;
            this.GridView_Borrow.Size = new System.Drawing.Size(821, 357);
            this.GridView_Borrow.TabIndex = 3;
            // 
            // Col1_BookName
            // 
            this.Col1_BookName.HeaderText = "书名";
            this.Col1_BookName.Name = "Col1_BookName";
            this.Col1_BookName.ReadOnly = true;
            // 
            // Col1_Label
            // 
            this.Col1_Label.HeaderText = "标签";
            this.Col1_Label.Name = "Col1_Label";
            this.Col1_Label.ReadOnly = true;
            // 
            // Col1_BookId
            // 
            this.Col1_BookId.HeaderText = "书号";
            this.Col1_BookId.Name = "Col1_BookId";
            this.Col1_BookId.ReadOnly = true;
            // 
            // Col1_Time
            // 
            this.Col1_Time.HeaderText = "借阅时长";
            this.Col1_Time.Name = "Col1_Time";
            this.Col1_Time.ReadOnly = true;
            // 
            // Submmit
            // 
            this.Submmit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Submmit.Location = new System.Drawing.Point(252, 564);
            this.Submmit.Name = "Submmit";
            this.Submmit.Size = new System.Drawing.Size(133, 45);
            this.Submmit.TabIndex = 5;
            this.Submmit.Text = "确认提交";
            this.Submmit.UseVisualStyleBackColor = true;
            this.Submmit.Click += new System.EventHandler(this.Submmit_Click);
            // 
            // button_return
            // 
            this.button_return.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_return.Location = new System.Drawing.Point(670, 564);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(118, 45);
            this.button_return.TabIndex = 6;
            this.button_return.Text = "退出";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.LastPage_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.ControlBox = false;
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.Submmit);
            this.Controls.Add(this.GridView_Borrow);
            this.Controls.Add(this.button_ReadInfo);
            this.Controls.Add(this.BookNum);
            this.Controls.Add(this.label1);
            this.Name = "BorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借书界面";
            ((System.ComponentModel.ISupportInitialize)(this.BookNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Borrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BookNum;
        private System.Windows.Forms.Button button_ReadInfo;
        private System.Windows.Forms.DataGridView GridView_Borrow;
        private System.Windows.Forms.Button Submmit;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_Time;
    }
}