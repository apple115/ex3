namespace WinFormsApp1
{
    partial class 教师界面
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
            ms快速访问 = new MenuStrip();
            快速访问ToolStripMenuItem = new ToolStripMenuItem();
            信息系统ToolStripMenuItem = new ToolStripMenuItem();
            课程系统ToolStripMenuItem = new ToolStripMenuItem();
            退出登录ToolStripMenuItem = new ToolStripMenuItem();
            dg课程列表 = new DataGridView();
            课号 = new DataGridViewTextBoxColumn();
            课名 = new DataGridViewTextBoxColumn();
            开始时间 = new DataGridViewTextBoxColumn();
            持续时间 = new DataGridViewTextBoxColumn();
            教师 = new DataGridViewTextBoxColumn();
            教室 = new DataGridViewTextBoxColumn();
            学院 = new DataGridViewTextBoxColumn();
            ab欢迎教师 = new Label();
            bt刷新 = new Button();
            bt我教授的课 = new Button();
            ms快速访问.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg课程列表).BeginInit();
            SuspendLayout();
            // 
            // ms快速访问
            // 
            ms快速访问.ImageScalingSize = new Size(20, 20);
            ms快速访问.Items.AddRange(new ToolStripItem[] { 快速访问ToolStripMenuItem });
            ms快速访问.Location = new Point(0, 0);
            ms快速访问.Name = "ms快速访问";
            ms快速访问.Size = new Size(982, 28);
            ms快速访问.TabIndex = 0;
            ms快速访问.Text = "menuStrip1";
            // 
            // 快速访问ToolStripMenuItem
            // 
            快速访问ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 信息系统ToolStripMenuItem, 课程系统ToolStripMenuItem, 退出登录ToolStripMenuItem });
            快速访问ToolStripMenuItem.Name = "快速访问ToolStripMenuItem";
            快速访问ToolStripMenuItem.Size = new Size(83, 24);
            快速访问ToolStripMenuItem.Text = "快速访问";
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
            // 退出登录ToolStripMenuItem
            // 
            退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            退出登录ToolStripMenuItem.Size = new Size(152, 26);
            退出登录ToolStripMenuItem.Text = "退出登录";
            退出登录ToolStripMenuItem.Click += 退出登录ToolStripMenuItem_Click;
            // 
            // dg课程列表
            // 
            dg课程列表.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg课程列表.Columns.AddRange(new DataGridViewColumn[] { 课号, 课名, 开始时间, 持续时间, 教师, 教室, 学院 });
            dg课程列表.Location = new Point(28, 112);
            dg课程列表.Name = "dg课程列表";
            dg课程列表.ReadOnly = true;
            dg课程列表.RowHeadersWidth = 51;
            dg课程列表.RowTemplate.Height = 29;
            dg课程列表.Size = new Size(930, 328);
            dg课程列表.TabIndex = 1;
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
            // ab欢迎教师
            // 
            ab欢迎教师.AutoSize = true;
            ab欢迎教师.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ab欢迎教师.Location = new Point(381, 68);
            ab欢迎教师.Name = "ab欢迎教师";
            ab欢迎教师.Size = new Size(253, 30);
            ab欢迎教师.TabIndex = 2;
            ab欢迎教师.Text = "欢迎来到教师界面";
            // 
            // bt刷新
            // 
            bt刷新.Location = new Point(28, 74);
            bt刷新.Name = "bt刷新";
            bt刷新.Size = new Size(102, 32);
            bt刷新.TabIndex = 3;
            bt刷新.Text = "刷新";
            bt刷新.UseVisualStyleBackColor = true;
            bt刷新.Click += bt刷新_Click;
            // 
            // bt我教授的课
            // 
            bt我教授的课.Location = new Point(28, 446);
            bt我教授的课.Name = "bt我教授的课";
            bt我教授的课.Size = new Size(111, 38);
            bt我教授的课.TabIndex = 4;
            bt我教授的课.Text = "我教授的课";
            bt我教授的课.UseVisualStyleBackColor = true;
            bt我教授的课.Click += bt我教授的课_Click;
            // 
            // 教师界面
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(bt我教授的课);
            Controls.Add(bt刷新);
            Controls.Add(ab欢迎教师);
            Controls.Add(dg课程列表);
            Controls.Add(ms快速访问);
            MainMenuStrip = ms快速访问;
            Name = "教师界面";
            Text = "教师界面";
            FormClosing += 教师界面_FormClosing;
            Load += 教师界面_Load;
            ms快速访问.ResumeLayout(false);
            ms快速访问.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg课程列表).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ms快速访问;
        private ToolStripMenuItem 快速访问ToolStripMenuItem;
        private ToolStripMenuItem 信息系统ToolStripMenuItem;
        private ToolStripMenuItem 课程系统ToolStripMenuItem;
        private ToolStripMenuItem 退出登录ToolStripMenuItem;
        private DataGridView dg课程列表;
        private DataGridViewTextBoxColumn 课号;
        private DataGridViewTextBoxColumn 课名;
        private DataGridViewTextBoxColumn 开始时间;
        private DataGridViewTextBoxColumn 持续时间;
        private DataGridViewTextBoxColumn 教师;
        private DataGridViewTextBoxColumn 教室;
        private DataGridViewTextBoxColumn 学院;
        private Label ab欢迎教师;
        private Button bt刷新;
        private Button bt我教授的课;
    }
}