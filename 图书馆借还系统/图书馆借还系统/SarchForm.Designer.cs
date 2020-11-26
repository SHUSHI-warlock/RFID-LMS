namespace 图书馆借还系统
{
    partial class SarchForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Now = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Timeout = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.GridView_Sch = new System.Windows.Forms.DataGridView();
            this.Col_Reader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ReadDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Sch)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label_Name);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label_Now);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label_Timeout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1062, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Name.Location = new System.Drawing.Point(68, 10);
            this.label_Name.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(99, 20);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "XXX您好！";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(173, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "当前已借:";
            // 
            // label_Now
            // 
            this.label_Now.AutoSize = true;
            this.label_Now.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Now.Location = new System.Drawing.Point(278, 10);
            this.label_Now.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label_Now.Name = "label_Now";
            this.label_Now.Size = new System.Drawing.Size(39, 20);
            this.label_Now.TabIndex = 3;
            this.label_Now.Text = "X本";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(323, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "超时待还:";
            // 
            // label_Timeout
            // 
            this.label_Timeout.AutoSize = true;
            this.label_Timeout.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Timeout.Location = new System.Drawing.Point(428, 10);
            this.label_Timeout.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label_Timeout.Name = "label_Timeout";
            this.label_Timeout.Size = new System.Drawing.Size(39, 20);
            this.label_Timeout.TabIndex = 5;
            this.label_Timeout.Text = "X本";
            // 
            // button_Return
            // 
            this.button_Return.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Return.Location = new System.Drawing.Point(363, 426);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(96, 36);
            this.button_Return.TabIndex = 2;
            this.button_Return.Text = "返回";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.LastPage_Click);
            // 
            // GridView_Sch
            // 
            this.GridView_Sch.AllowUserToAddRows = false;
            this.GridView_Sch.AllowUserToDeleteRows = false;
            this.GridView_Sch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Sch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Reader,
            this.Col_BookId,
            this.Col_BookName,
            this.Col_Start,
            this.Col_Deadline,
            this.Col_ReadDay,
            this.Col_Status});
            this.GridView_Sch.Location = new System.Drawing.Point(41, 80);
            this.GridView_Sch.Name = "GridView_Sch";
            this.GridView_Sch.ReadOnly = true;
            this.GridView_Sch.RowHeadersWidth = 51;
            this.GridView_Sch.RowTemplate.Height = 27;
            this.GridView_Sch.Size = new System.Drawing.Size(746, 340);
            this.GridView_Sch.TabIndex = 3;
            // 
            // Col_Reader
            // 
            this.Col_Reader.HeaderText = "读者ID";
            this.Col_Reader.MinimumWidth = 6;
            this.Col_Reader.Name = "Col_Reader";
            this.Col_Reader.ReadOnly = true;
            this.Col_Reader.Width = 125;
            // 
            // Col_BookId
            // 
            this.Col_BookId.HeaderText = "书号";
            this.Col_BookId.MinimumWidth = 6;
            this.Col_BookId.Name = "Col_BookId";
            this.Col_BookId.ReadOnly = true;
            this.Col_BookId.Width = 125;
            // 
            // Col_BookName
            // 
            this.Col_BookName.HeaderText = "书名";
            this.Col_BookName.MinimumWidth = 6;
            this.Col_BookName.Name = "Col_BookName";
            this.Col_BookName.ReadOnly = true;
            this.Col_BookName.Width = 125;
            // 
            // Col_Start
            // 
            this.Col_Start.HeaderText = "借阅日期";
            this.Col_Start.MinimumWidth = 6;
            this.Col_Start.Name = "Col_Start";
            this.Col_Start.ReadOnly = true;
            this.Col_Start.Width = 125;
            // 
            // Col_Deadline
            // 
            this.Col_Deadline.HeaderText = "借阅期限";
            this.Col_Deadline.MinimumWidth = 6;
            this.Col_Deadline.Name = "Col_Deadline";
            this.Col_Deadline.ReadOnly = true;
            this.Col_Deadline.Width = 125;
            // 
            // Col_ReadDay
            // 
            this.Col_ReadDay.HeaderText = "借阅天数";
            this.Col_ReadDay.MinimumWidth = 6;
            this.Col_ReadDay.Name = "Col_ReadDay";
            this.Col_ReadDay.ReadOnly = true;
            this.Col_ReadDay.Width = 125;
            // 
            // Col_Status
            // 
            this.Col_Status.HeaderText = "借阅状态";
            this.Col_Status.MinimumWidth = 6;
            this.Col_Status.Name = "Col_Status";
            this.Col_Status.ReadOnly = true;
            this.Col_Status.Width = 125;
            // 
            // SarchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.ControlBox = false;
            this.Controls.Add(this.GridView_Sch);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SarchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借还信息界面";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Sch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.DataGridView GridView_Sch;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Now;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Timeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Reader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ReadDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Status;
    }
}