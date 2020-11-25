namespace 图书管理系统
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GridView_Books = new System.Windows.Forms.DataGridView();
            this.Col1_BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_AllNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1_NowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_BookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.bt_searchbook = new System.Windows.Forms.Button();
            this.bt_addbook = new System.Windows.Forms.Button();
            this.bt_delbook = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col2_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bt_searchReader = new System.Windows.Forms.Button();
            this.bt_addReader = new System.Windows.Forms.Button();
            this.bt_changeReader = new System.Windows.Forms.Button();
            this.bt_delReader = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Col_ReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_BookId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3_StartDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3_Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3_ReadDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IsReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Col1_tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Books)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GridView_Books);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1113, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图书信息管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // GridView_Books
            // 
            this.GridView_Books.AllowUserToAddRows = false;
            this.GridView_Books.AllowUserToDeleteRows = false;
            this.GridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1_BookId,
            this.Col1_BookName,
            this.Col1_Author,
            this.Col1_Class,
            this.Col1_AllNum,
            this.Col1_NowNum});
            this.GridView_Books.Enabled = false;
            this.GridView_Books.Location = new System.Drawing.Point(6, 78);
            this.GridView_Books.Name = "GridView_Books";
            this.GridView_Books.ReadOnly = true;
            this.GridView_Books.RowHeadersWidth = 51;
            this.GridView_Books.RowTemplate.Height = 27;
            this.GridView_Books.Size = new System.Drawing.Size(1072, 421);
            this.GridView_Books.TabIndex = 3;
            // 
            // Col1_BookId
            // 
            this.Col1_BookId.HeaderText = "图书号";
            this.Col1_BookId.MinimumWidth = 6;
            this.Col1_BookId.Name = "Col1_BookId";
            this.Col1_BookId.ReadOnly = true;
            this.Col1_BookId.Width = 125;
            // 
            // Col1_BookName
            // 
            this.Col1_BookName.HeaderText = "图书名";
            this.Col1_BookName.MinimumWidth = 6;
            this.Col1_BookName.Name = "Col1_BookName";
            this.Col1_BookName.ReadOnly = true;
            this.Col1_BookName.Width = 125;
            // 
            // Col1_Author
            // 
            this.Col1_Author.HeaderText = "作者";
            this.Col1_Author.MinimumWidth = 6;
            this.Col1_Author.Name = "Col1_Author";
            this.Col1_Author.ReadOnly = true;
            this.Col1_Author.Width = 125;
            // 
            // Col1_Class
            // 
            this.Col1_Class.HeaderText = "分类";
            this.Col1_Class.MinimumWidth = 6;
            this.Col1_Class.Name = "Col1_Class";
            this.Col1_Class.ReadOnly = true;
            this.Col1_Class.Width = 125;
            // 
            // Col1_AllNum
            // 
            this.Col1_AllNum.HeaderText = "总库存";
            this.Col1_AllNum.MinimumWidth = 6;
            this.Col1_AllNum.Name = "Col1_AllNum";
            this.Col1_AllNum.ReadOnly = true;
            this.Col1_AllNum.Width = 125;
            // 
            // Col1_NowNum
            // 
            this.Col1_NowNum.HeaderText = "当前馆存";
            this.Col1_NowNum.MinimumWidth = 6;
            this.Col1_NowNum.Name = "Col1_NowNum";
            this.Col1_NowNum.ReadOnly = true;
            this.Col1_NowNum.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.tb_BookName);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.tb_author);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.cb_class);
            this.flowLayoutPanel1.Controls.Add(this.bt_searchbook);
            this.flowLayoutPanel1.Controls.Add(this.bt_addbook);
            this.flowLayoutPanel1.Controls.Add(this.bt_delbook);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1107, 69);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "书名:";
            // 
            // tb_BookName
            // 
            this.tb_BookName.Location = new System.Drawing.Point(74, 3);
            this.tb_BookName.Name = "tb_BookName";
            this.tb_BookName.Size = new System.Drawing.Size(147, 25);
            this.tb_BookName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(227, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "作者:";
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(298, 3);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(141, 25);
            this.tb_author.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(445, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "分类:";
            // 
            // cb_class
            // 
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "数学",
            "英语",
            "文学",
            "物理",
            "化学",
            "计算机"});
            this.cb_class.Location = new System.Drawing.Point(516, 3);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(136, 23);
            this.cb_class.TabIndex = 11;
            // 
            // bt_searchbook
            // 
            this.bt_searchbook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_searchbook.Location = new System.Drawing.Point(685, 3);
            this.bt_searchbook.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.bt_searchbook.Name = "bt_searchbook";
            this.bt_searchbook.Size = new System.Drawing.Size(108, 45);
            this.bt_searchbook.TabIndex = 12;
            this.bt_searchbook.Text = "查询";
            this.bt_searchbook.UseVisualStyleBackColor = true;
            this.bt_searchbook.Click += new System.EventHandler(this.bt_searchbook_Click);
            // 
            // bt_addbook
            // 
            this.bt_addbook.AutoSize = true;
            this.bt_addbook.Location = new System.Drawing.Point(806, 3);
            this.bt_addbook.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bt_addbook.Name = "bt_addbook";
            this.bt_addbook.Size = new System.Drawing.Size(108, 45);
            this.bt_addbook.TabIndex = 1;
            this.bt_addbook.Text = "图书入库";
            this.bt_addbook.UseVisualStyleBackColor = true;
            this.bt_addbook.Click += new System.EventHandler(this.bt_addbook_Click);
            // 
            // bt_delbook
            // 
            this.bt_delbook.AutoSize = true;
            this.bt_delbook.Location = new System.Drawing.Point(927, 3);
            this.bt_delbook.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bt_delbook.Name = "bt_delbook";
            this.bt_delbook.Size = new System.Drawing.Size(108, 45);
            this.bt_delbook.TabIndex = 2;
            this.bt_delbook.Text = "图书出库";
            this.bt_delbook.UseVisualStyleBackColor = true;
            this.bt_delbook.Click += new System.EventHandler(this.bt_delbook_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1113, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "读者信息管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col2_ID,
            this.Col2_Password});
            this.dataGridView1.Location = new System.Drawing.Point(28, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(469, 234);
            this.dataGridView1.TabIndex = 1;
            // 
            // Col2_ID
            // 
            this.Col2_ID.HeaderText = "读者ID";
            this.Col2_ID.MinimumWidth = 6;
            this.Col2_ID.Name = "Col2_ID";
            this.Col2_ID.ReadOnly = true;
            this.Col2_ID.Width = 125;
            // 
            // Col2_Password
            // 
            this.Col2_Password.HeaderText = "密码";
            this.Col2_Password.MinimumWidth = 6;
            this.Col2_Password.Name = "Col2_Password";
            this.Col2_Password.Width = 125;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.textBox4);
            this.flowLayoutPanel2.Controls.Add(this.bt_searchReader);
            this.flowLayoutPanel2.Controls.Add(this.bt_addReader);
            this.flowLayoutPanel2.Controls.Add(this.bt_changeReader);
            this.flowLayoutPanel2.Controls.Add(this.bt_delReader);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1107, 46);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 37);
            this.label10.TabIndex = 1;
            this.label10.Text = "读者ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 2;
            // 
            // bt_searchReader
            // 
            this.bt_searchReader.Location = new System.Drawing.Point(207, 3);
            this.bt_searchReader.Name = "bt_searchReader";
            this.bt_searchReader.Size = new System.Drawing.Size(75, 34);
            this.bt_searchReader.TabIndex = 3;
            this.bt_searchReader.Text = "查询";
            this.bt_searchReader.UseVisualStyleBackColor = true;
            // 
            // bt_addReader
            // 
            this.bt_addReader.Location = new System.Drawing.Point(288, 3);
            this.bt_addReader.Name = "bt_addReader";
            this.bt_addReader.Size = new System.Drawing.Size(75, 34);
            this.bt_addReader.TabIndex = 4;
            this.bt_addReader.Text = "添加读者";
            this.bt_addReader.UseVisualStyleBackColor = true;
            // 
            // bt_changeReader
            // 
            this.bt_changeReader.Location = new System.Drawing.Point(369, 3);
            this.bt_changeReader.Name = "bt_changeReader";
            this.bt_changeReader.Size = new System.Drawing.Size(75, 34);
            this.bt_changeReader.TabIndex = 6;
            this.bt_changeReader.Text = "修改读者";
            this.bt_changeReader.UseVisualStyleBackColor = true;
            // 
            // bt_delReader
            // 
            this.bt_delReader.Location = new System.Drawing.Point(450, 3);
            this.bt_delReader.Name = "bt_delReader";
            this.bt_delReader.Size = new System.Drawing.Size(75, 34);
            this.bt_delReader.TabIndex = 5;
            this.bt_delReader.Text = "删除读者";
            this.bt_delReader.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel4);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1113, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "借阅信息管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ReaderID,
            this.Col_BookId2,
            this.Col3_StartDay,
            this.Col3_Deadline,
            this.Col3_ReadDay,
            this.Col_IsReturn});
            this.dataGridView2.Location = new System.Drawing.Point(7, 109);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(1071, 410);
            this.dataGridView2.TabIndex = 1;
            // 
            // Col_ReaderID
            // 
            this.Col_ReaderID.HeaderText = "读者ID";
            this.Col_ReaderID.MinimumWidth = 6;
            this.Col_ReaderID.Name = "Col_ReaderID";
            this.Col_ReaderID.ReadOnly = true;
            this.Col_ReaderID.Width = 125;
            // 
            // Col_BookId2
            // 
            this.Col_BookId2.HeaderText = "图书号";
            this.Col_BookId2.MinimumWidth = 6;
            this.Col_BookId2.Name = "Col_BookId2";
            this.Col_BookId2.ReadOnly = true;
            this.Col_BookId2.Width = 125;
            // 
            // Col3_StartDay
            // 
            this.Col3_StartDay.HeaderText = "借阅日期";
            this.Col3_StartDay.MinimumWidth = 6;
            this.Col3_StartDay.Name = "Col3_StartDay";
            this.Col3_StartDay.ReadOnly = true;
            this.Col3_StartDay.Width = 125;
            // 
            // Col3_Deadline
            // 
            this.Col3_Deadline.HeaderText = "借阅期限";
            this.Col3_Deadline.MinimumWidth = 6;
            this.Col3_Deadline.Name = "Col3_Deadline";
            this.Col3_Deadline.ReadOnly = true;
            this.Col3_Deadline.Width = 125;
            // 
            // Col3_ReadDay
            // 
            this.Col3_ReadDay.HeaderText = "已借天数";
            this.Col3_ReadDay.MinimumWidth = 6;
            this.Col3_ReadDay.Name = "Col3_ReadDay";
            this.Col3_ReadDay.ReadOnly = true;
            this.Col3_ReadDay.Width = 125;
            // 
            // Col_IsReturn
            // 
            this.Col_IsReturn.HeaderText = "是否归还";
            this.Col_IsReturn.MinimumWidth = 6;
            this.Col_IsReturn.Name = "Col_IsReturn";
            this.Col_IsReturn.ReadOnly = true;
            this.Col_IsReturn.Width = 125;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label11);
            this.flowLayoutPanel3.Controls.Add(this.textBox5);
            this.flowLayoutPanel3.Controls.Add(this.label12);
            this.flowLayoutPanel3.Controls.Add(this.textBox6);
            this.flowLayoutPanel3.Controls.Add(this.bt_Search);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1113, 75);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "读者ID:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 25);
            this.textBox5.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(334, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 31);
            this.label12.TabIndex = 2;
            this.label12.Text = "书号:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(471, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 25);
            this.textBox6.TabIndex = 3;
            // 
            // Col1_tag
            // 
            this.Col1_tag.MinimumWidth = 6;
            this.Col1_tag.Name = "Col1_tag";
            this.Col1_tag.Width = 125;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.dateTimePicker2);
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.comboBox1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 75);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1113, 34);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "借阅日期:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(142, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(186, 25);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(334, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "状态:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "借阅中",
            "已还",
            "超时未还"});
            this.comboBox1.Location = new System.Drawing.Point(471, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(683, 3);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(118, 62);
            this.bt_Search.TabIndex = 7;
            this.bt_Search.Text = "查询";
            this.bt_Search.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 620);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "图书管理软件";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Books)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bt_addbook;
        private System.Windows.Forms.DataGridView GridView_Books;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_BookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.Button bt_searchbook;
        private System.Windows.Forms.Button bt_delbook;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button bt_searchReader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_addReader;
        private System.Windows.Forms.Button bt_changeReader;
        private System.Windows.Forms.Button bt_delReader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2_Password;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BookId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3_StartDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3_Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3_ReadDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IsReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_AllNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1_NowNum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_Search;
    }
}

