namespace WinFormsApp1
{
    partial class 选课界面
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
            lb筛选 = new Label();
            lb欢迎来到选课界面 = new Label();
            label1 = new Label();
            label2 = new Label();
            cb教师 = new ComboBox();
            cb学院 = new ComboBox();
            menuStrip1 = new MenuStrip();
            退出登录ToolStripMenuItem = new ToolStripMenuItem();
            信息系统ToolStripMenuItem = new ToolStripMenuItem();
            课程系统ToolStripMenuItem = new ToolStripMenuItem();
            退出登录ToolStripMenuItem1 = new ToolStripMenuItem();
            dg课程列表 = new DataGridView();
            课号 = new DataGridViewTextBoxColumn();
            课名 = new DataGridViewTextBoxColumn();
            开始时间 = new DataGridViewTextBoxColumn();
            持续时间 = new DataGridViewTextBoxColumn();
            教师 = new DataGridViewTextBoxColumn();
            教室 = new DataGridViewTextBoxColumn();
            学院 = new DataGridViewTextBoxColumn();
            bt选课 = new Button();
            lb欢迎同学 = new Label();
            bt刷新 = new Button();
            lb剩余学分 = new Label();
            AutoCourseTable = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg课程列表).BeginInit();
            SuspendLayout();
            // 
            // lb筛选
            // 
            lb筛选.AutoSize = true;
            lb筛选.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb筛选.Location = new Point(202, 94);
            lb筛选.Name = "lb筛选";
            lb筛选.Size = new Size(82, 23);
            lb筛选.TabIndex = 0;
            lb筛选.Text = "筛选：";
            // 
            // lb欢迎来到选课界面
            // 
            lb欢迎来到选课界面.AutoSize = true;
            lb欢迎来到选课界面.Font = new Font("宋体", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb欢迎来到选课界面.Location = new Point(423, 37);
            lb欢迎来到选课界面.Name = "lb欢迎来到选课界面";
            lb欢迎来到选课界面.Size = new Size(253, 30);
            lb欢迎来到选课界面.TabIndex = 1;
            lb欢迎来到选课界面.Text = "欢迎来到选课界面";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 95);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 2;
            label1.Text = "教师：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(561, 95);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 3;
            label2.Text = "学院：";
            // 
            // cb教师
            // 
            cb教师.FormattingEnabled = true;
            cb教师.Location = new Point(380, 95);
            cb教师.Name = "cb教师";
            cb教师.Size = new Size(126, 28);
            cb教师.TabIndex = 4;
            cb教师.SelectedIndexChanged += cb教师_SelectedIndexChanged;
            // 
            // cb学院
            // 
            cb学院.FormattingEnabled = true;
            cb学院.Location = new Point(649, 95);
            cb学院.Name = "cb学院";
            cb学院.Size = new Size(126, 28);
            cb学院.TabIndex = 5;
            cb学院.SelectedIndexChanged += cb学院_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 退出登录ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1082, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // 退出登录ToolStripMenuItem
            // 
            退出登录ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 信息系统ToolStripMenuItem, 课程系统ToolStripMenuItem, 退出登录ToolStripMenuItem1 });
            退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            退出登录ToolStripMenuItem.Size = new Size(83, 24);
            退出登录ToolStripMenuItem.Text = "快速访问";
            // 
            // 信息系统ToolStripMenuItem
            // 
            信息系统ToolStripMenuItem.Name = "信息系统ToolStripMenuItem";
            信息系统ToolStripMenuItem.Size = new Size(152, 26);
            信息系统ToolStripMenuItem.Text = "信息系统";
            // 
            // 课程系统ToolStripMenuItem
            // 
            课程系统ToolStripMenuItem.Name = "课程系统ToolStripMenuItem";
            课程系统ToolStripMenuItem.Size = new Size(152, 26);
            课程系统ToolStripMenuItem.Text = "课程系统";
            // 
            // 退出登录ToolStripMenuItem1
            // 
            退出登录ToolStripMenuItem1.Name = "退出登录ToolStripMenuItem1";
            退出登录ToolStripMenuItem1.Size = new Size(152, 26);
            退出登录ToolStripMenuItem1.Text = "退出登录";
            退出登录ToolStripMenuItem1.Click += 退出登录ToolStripMenuItem1_Click;
            // 
            // dg课程列表
            // 
            dg课程列表.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg课程列表.Columns.AddRange(new DataGridViewColumn[] { 课号, 课名, 开始时间, 持续时间, 教师, 教室, 学院 });
            dg课程列表.Location = new Point(12, 160);
            dg课程列表.Name = "dg课程列表";
            dg课程列表.RowHeadersWidth = 51;
            dg课程列表.RowTemplate.Height = 29;
            dg课程列表.Size = new Size(1053, 319);
            dg课程列表.TabIndex = 8;
            dg课程列表.CellDoubleClick += dg课程列表_CellDoubleClick;
            // 
            // 课号
            // 
            课号.HeaderText = "课号";
            课号.MinimumWidth = 6;
            课号.Name = "课号";
            课号.ReadOnly = true;
            课号.Width = 125;
            // 
            // 课名
            // 
            课名.HeaderText = "课名";
            课名.MinimumWidth = 6;
            课名.Name = "课名";
            课名.ReadOnly = true;
            课名.Width = 125;
            // 
            // 开始时间
            // 
            开始时间.HeaderText = "开始时间";
            开始时间.MinimumWidth = 6;
            开始时间.Name = "开始时间";
            开始时间.ReadOnly = true;
            开始时间.Width = 125;
            // 
            // 持续时间
            // 
            持续时间.HeaderText = "持续时间";
            持续时间.MinimumWidth = 6;
            持续时间.Name = "持续时间";
            持续时间.ReadOnly = true;
            持续时间.Width = 125;
            // 
            // 教师
            // 
            教师.HeaderText = "教师";
            教师.MinimumWidth = 6;
            教师.Name = "教师";
            教师.ReadOnly = true;
            教师.Width = 125;
            // 
            // 教室
            // 
            教室.HeaderText = "教室";
            教室.MinimumWidth = 6;
            教室.Name = "教室";
            教室.ReadOnly = true;
            教室.Width = 125;
            // 
            // 学院
            // 
            学院.HeaderText = "学院";
            学院.MinimumWidth = 6;
            学院.Name = "学院";
            学院.ReadOnly = true;
            学院.Width = 125;
            // 
            // bt选课
            // 
            bt选课.Location = new Point(401, 485);
            bt选课.Name = "bt选课";
            bt选课.Size = new Size(315, 31);
            bt选课.TabIndex = 9;
            bt选课.Text = "选课";
            bt选课.UseVisualStyleBackColor = true;
            bt选课.Click += bt选课_Click;
            // 
            // lb欢迎同学
            // 
            lb欢迎同学.AutoSize = true;
            lb欢迎同学.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb欢迎同学.Location = new Point(864, 37);
            lb欢迎同学.Name = "lb欢迎同学";
            lb欢迎同学.Size = new Size(92, 27);
            lb欢迎同学.TabIndex = 10;
            lb欢迎同学.Text = "欢迎同学";
            lb欢迎同学.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt刷新
            // 
            bt刷新.Location = new Point(12, 120);
            bt刷新.Name = "bt刷新";
            bt刷新.Size = new Size(91, 34);
            bt刷新.TabIndex = 11;
            bt刷新.Text = "刷新";
            bt刷新.UseVisualStyleBackColor = true;
            bt刷新.Click += bt刷新_Click;
            // 
            // lb剩余学分
            // 
            lb剩余学分.AutoSize = true;
            lb剩余学分.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb剩余学分.Location = new Point(916, 126);
            lb剩余学分.Name = "lb剩余学分";
            lb剩余学分.Size = new Size(149, 20);
            lb剩余学分.TabIndex = 12;
            lb剩余学分.Text = "你还剩多少学分";
            // 
            // AutoCourseTable
            // 
            AutoCourseTable.Location = new Point(12, 43);
            AutoCourseTable.Name = "AutoCourseTable";
            AutoCourseTable.Size = new Size(170, 29);
            AutoCourseTable.TabIndex = 13;
            AutoCourseTable.Text = "查看当前课表";
            AutoCourseTable.UseVisualStyleBackColor = true;
            AutoCourseTable.Click += AutoCourseTable_Click;
            // 
            // 选课界面
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 554);
            Controls.Add(AutoCourseTable);
            Controls.Add(lb剩余学分);
            Controls.Add(bt刷新);
            Controls.Add(lb欢迎同学);
            Controls.Add(bt选课);
            Controls.Add(dg课程列表);
            Controls.Add(menuStrip1);
            Controls.Add(cb学院);
            Controls.Add(cb教师);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb欢迎来到选课界面);
            Controls.Add(lb筛选);
            MainMenuStrip = menuStrip1;
            Name = "选课界面";
            Text = "选课界面";
            FormClosing += 选课界面_FormClosing;
            Load += 选课界面_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg课程列表).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb筛选;
        private Label lb欢迎来到选课界面;
        private Label label1;
        private Label label2;
        private ComboBox cb教师;
        private ComboBox cb学院;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 退出登录ToolStripMenuItem;
        private DataGridView dg课程列表;
        private ToolStripMenuItem 信息系统ToolStripMenuItem;
        private ToolStripMenuItem 课程系统ToolStripMenuItem;
        private ToolStripMenuItem 退出登录ToolStripMenuItem1;
        private Button bt选课;
        private Label lb欢迎同学;
        private Button bt刷新;
        private Label lb剩余学分;
        private DataGridViewTextBoxColumn 课号;
        private DataGridViewTextBoxColumn 课名;
        private DataGridViewTextBoxColumn 开始时间;
        private DataGridViewTextBoxColumn 持续时间;
        private DataGridViewTextBoxColumn 教师;
        private DataGridViewTextBoxColumn 教室;
        private DataGridViewTextBoxColumn 学院;
        private Button AutoCourseTable;
    }
}