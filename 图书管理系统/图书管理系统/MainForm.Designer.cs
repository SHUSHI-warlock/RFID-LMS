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
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bt_Null = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.GridView_Borrow = new System.Windows.Forms.DataGridView();
            this.Col_ReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_BookId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3_StartDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3_Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3_ReadDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IsReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Pid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Bid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_states = new System.Windows.Forms.ComboBox();
            this.Col1_tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Books)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Borrow)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
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
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "书名:";
            // 
            // tb_BookName
            // 
            this.tb_BookName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_BookName.Location = new System.Drawing.Point(74, 23);
            this.tb_BookName.Name = "tb_BookName";
            this.tb_BookName.Size = new System.Drawing.Size(147, 25);
            this.tb_BookName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(227, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "作者:";
            // 
            // tb_author
            // 
            this.tb_author.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_author.Location = new System.Drawing.Point(298, 23);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(141, 25);
            this.tb_author.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(445, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "分类:";
            // 
            // cb_class
            // 
            this.cb_class.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Items.AddRange(new object[] {
            "数学",
            "英语",
            "文学",
            "物理",
            "化学",
            "计算机"});
            this.cb_class.Location = new System.Drawing.Point(516, 24);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(136, 23);
            this.cb_class.TabIndex = 11;
            // 
            // bt_searchbook
            // 
            this.bt_searchbook.Font = new System.Drawing.Font("宋体", 12F);
            this.bt_searchbook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_searchbook.Location = new System.Drawing.Point(685, 3);
            this.bt_searchbook.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.bt_searchbook.Name = "bt_searchbook";
            this.bt_searchbook.Size = new System.Drawing.Size(108, 66);
            this.bt_searchbook.TabIndex = 12;
            this.bt_searchbook.Text = "查询";
            this.bt_searchbook.UseVisualStyleBackColor = true;
            this.bt_searchbook.Click += new System.EventHandler(this.bt_searchbook_Click);
            // 
            // bt_addbook
            // 
            this.bt_addbook.AutoSize = true;
            this.bt_addbook.Font = new System.Drawing.Font("宋体", 12F);
            this.bt_addbook.Location = new System.Drawing.Point(806, 3);
            this.bt_addbook.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bt_addbook.Name = "bt_addbook";
            this.bt_addbook.Size = new System.Drawing.Size(108, 66);
            this.bt_addbook.TabIndex = 1;
            this.bt_addbook.Text = "图书入库";
            this.bt_addbook.UseVisualStyleBackColor = true;
            this.bt_addbook.Click += new System.EventHandler(this.bt_addbook_Click);
            // 
            // bt_delbook
            // 
            this.bt_delbook.AutoSize = true;
            this.bt_delbook.Font = new System.Drawing.Font("宋体", 12F);
            this.bt_delbook.Location = new System.Drawing.Point(927, 3);
            this.bt_delbook.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bt_delbook.Name = "bt_delbook";
            this.bt_delbook.Size = new System.Drawing.Size(110, 66);
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
            this.tabPage3.Controls.Add(this.GridView_Borrow);
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1113, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "借阅信息管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.tb_time);
            this.flowLayoutPanel4.Controls.Add(this.dateTimePicker);
            this.flowLayoutPanel4.Controls.Add(this.bt_Null);
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.bt_Search);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1113, 60);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "借阅日期：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_time
            // 
            this.tb_time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_time.Location = new System.Drawing.Point(169, 19);
            this.tb_time.Name = "tb_time";
            this.tb_time.ReadOnly = true;
            this.tb_time.Size = new System.Drawing.Size(212, 25);
            this.tb_time.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.AllowDrop = true;
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("宋体", 1F);
            this.dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker.Location = new System.Drawing.Point(387, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(20, 25);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // bt_Null
            // 
            this.bt_Null.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_Null.Font = new System.Drawing.Font("宋体", 8F);
            this.bt_Null.Location = new System.Drawing.Point(413, 19);
            this.bt_Null.Name = "bt_Null";
            this.bt_Null.Size = new System.Drawing.Size(105, 25);
            this.bt_Null.TabIndex = 8;
            this.bt_Null.Text = "清空时间";
            this.bt_Null.UseVisualStyleBackColor = true;
            this.bt_Null.Click += new System.EventHandler(this.bt_Null_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(524, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 31);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_Search
            // 
            this.bt_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bt_Search.Font = new System.Drawing.Font("宋体", 12F);
            this.bt_Search.Location = new System.Drawing.Point(906, 3);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(94, 57);
            this.bt_Search.TabIndex = 7;
            this.bt_Search.Text = "查询";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // GridView_Borrow
            // 
            this.GridView_Borrow.AllowUserToAddRows = false;
            this.GridView_Borrow.AllowUserToDeleteRows = false;
            this.GridView_Borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Borrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ReaderID,
            this.Col_BookId2,
            this.Col3_StartDay,
            this.Col3_Deadline,
            this.Col3_ReadDay,
            this.Col_IsReturn});
            this.GridView_Borrow.Location = new System.Drawing.Point(7, 109);
            this.GridView_Borrow.Name = "GridView_Borrow";
            this.GridView_Borrow.ReadOnly = true;
            this.GridView_Borrow.RowHeadersWidth = 51;
            this.GridView_Borrow.RowTemplate.Height = 27;
            this.GridView_Borrow.Size = new System.Drawing.Size(1071, 410);
            this.GridView_Borrow.TabIndex = 1;
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
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.tb_Pid);
            this.flowLayoutPanel3.Controls.Add(this.label12);
            this.flowLayoutPanel3.Controls.Add(this.tb_Bid);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.cb_states);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1113, 43);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "读者号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Pid
            // 
            this.tb_Pid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Pid.Location = new System.Drawing.Point(169, 3);
            this.tb_Pid.Name = "tb_Pid";
            this.tb_Pid.Size = new System.Drawing.Size(149, 25);
            this.tb_Pid.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(324, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 31);
            this.label12.TabIndex = 2;
            this.label12.Text = "图书号：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Bid
            // 
            this.tb_Bid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Bid.Location = new System.Drawing.Point(455, 3);
            this.tb_Bid.Name = "tb_Bid";
            this.tb_Bid.Size = new System.Drawing.Size(163, 25);
            this.tb_Bid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(624, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "当前状态：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_states
            // 
            this.cb_states.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_states.FormattingEnabled = true;
            this.cb_states.Items.AddRange(new object[] {
            "借阅中",
            "已归还",
            "已超时"});
            this.cb_states.Location = new System.Drawing.Point(777, 4);
            this.cb_states.Name = "cb_states";
            this.cb_states.Size = new System.Drawing.Size(123, 23);
            this.cb_states.TabIndex = 5;
            // 
            // Col1_tag
            // 
            this.Col1_tag.MinimumWidth = 6;
            this.Col1_tag.Name = "Col1_tag";
            this.Col1_tag.Width = 125;
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
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Borrow)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.TextBox tb_Pid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2_Password;
        private System.Windows.Forms.DataGridView GridView_Borrow;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_states;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Button bt_Null;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

