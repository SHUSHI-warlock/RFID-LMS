namespace 图书馆借还系统
{
    partial class ReturnForm
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
            this.GridView_Return = new System.Windows.Forms.DataGridView();
            this.Col1_Reader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ReadInfo = new System.Windows.Forms.Button();
            this.BookNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.Submmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookNum)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView_Return
            // 
            this.GridView_Return.AllowUserToAddRows = false;
            this.GridView_Return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Return.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1_Reader,
            this.Col1_BookName,
            this.Col1_BookId,
            this.Col1_Start,
            this.Col1_Deadline,
            this.Col1_Status,
            this.Col1_Label});
            this.GridView_Return.Location = new System.Drawing.Point(58, 114);
            this.GridView_Return.Name = "GridView_Return";
            this.GridView_Return.ReadOnly = true;
            this.GridView_Return.RowTemplate.Height = 27;
            this.GridView_Return.Size = new System.Drawing.Size(733, 238);
            this.GridView_Return.TabIndex = 10;
            // 
            // Col1_Reader
            // 
            this.Col1_Reader.HeaderText = "读者ID";
            this.Col1_Reader.Name = "Col1_Reader";
            this.Col1_Reader.ReadOnly = true;
            // 
            // Col1_BookName
            // 
            this.Col1_BookName.HeaderText = "书名";
            this.Col1_BookName.Name = "Col1_BookName";
            this.Col1_BookName.ReadOnly = true;
            // 
            // Col1_BookId
            // 
            this.Col1_BookId.HeaderText = "书号";
            this.Col1_BookId.Name = "Col1_BookId";
            this.Col1_BookId.ReadOnly = true;
            // 
            // Col1_Start
            // 
            this.Col1_Start.HeaderText = "起借日期";
            this.Col1_Start.Name = "Col1_Start";
            this.Col1_Start.ReadOnly = true;
            // 
            // Col1_Deadline
            // 
            this.Col1_Deadline.HeaderText = "截止日期";
            this.Col1_Deadline.Name = "Col1_Deadline";
            this.Col1_Deadline.ReadOnly = true;
            // 
            // Col1_Status
            // 
            this.Col1_Status.HeaderText = "书籍状态";
            this.Col1_Status.Name = "Col1_Status";
            this.Col1_Status.ReadOnly = true;
            // 
            // Col1_Label
            // 
            this.Col1_Label.HeaderText = "标签";
            this.Col1_Label.Name = "Col1_Label";
            this.Col1_Label.ReadOnly = true;
            // 
            // button_ReadInfo
            // 
            this.button_ReadInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ReadInfo.Location = new System.Drawing.Point(531, 30);
            this.button_ReadInfo.Name = "button_ReadInfo";
            this.button_ReadInfo.Size = new System.Drawing.Size(202, 68);
            this.button_ReadInfo.TabIndex = 9;
            this.button_ReadInfo.Text = "读取书籍信息";
            this.button_ReadInfo.UseVisualStyleBackColor = true;
            this.button_ReadInfo.Click += new System.EventHandler(this.button_ReadInfo_Click);
            // 
            // BookNum
            // 
            this.BookNum.Location = new System.Drawing.Point(200, 30);
            this.BookNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BookNum.Name = "BookNum";
            this.BookNum.Size = new System.Drawing.Size(120, 25);
            this.BookNum.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "本次还书本数:";
            // 
            // button_Return
            // 
            this.button_Return.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Return.Location = new System.Drawing.Point(457, 388);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(118, 45);
            this.button_Return.TabIndex = 13;
            this.button_Return.Text = "退出";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.LastPage_Click);
            // 
            // Submmit
            // 
            this.Submmit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Submmit.Location = new System.Drawing.Point(222, 388);
            this.Submmit.Name = "Submmit";
            this.Submmit.Size = new System.Drawing.Size(133, 45);
            this.Submmit.TabIndex = 12;
            this.Submmit.Text = "确认提交";
            this.Submmit.UseVisualStyleBackColor = true;
            this.Submmit.Click += new System.EventHandler(this.Submmit_Click);
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.ControlBox = false;
            this.Controls.Add(this.GridView_Return);
            this.Controls.Add(this.button_ReadInfo);
            this.Controls.Add(this.BookNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.Submmit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "还书界面";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView_Return;
        private System.Windows.Forms.Button button_ReadInfo;
        private System.Windows.Forms.NumericUpDown BookNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button Submmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_Reader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_Label;
    }
}