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
            推荐选课ToolStripMenuItem = new ToolStripMenuItem();
            查看已投ToolStripMenuItem = new ToolStripMenuItem();
            dg课程列表 = new DataGridView();
            课号 = new DataGridViewTextBoxColumn();
            课名 = new DataGridViewTextBoxColumn();
            开始时间 = new DataGridViewTextBoxColumn();
            持续时间 = new DataGridViewTextBoxColumn();
            教师 = new DataGridViewTextBoxColumn();
            教室 = new DataGridViewTextBoxColumn();
            学院 = new DataGridViewTextBoxColumn();
            人数 = new DataGridViewTextBoxColumn();
            已选人数 = new DataGridViewTextBoxColumn();
            bt选课 = new Button();
            lb欢迎同学 = new Label();
            bt刷新 = new Button();
            lb剩余学分 = new Label();
            textBox_inputScore = new TextBox();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg课程列表).BeginInit();
            SuspendLayout();
            // 
            // lb筛选
            // 
            lb筛选.AutoSize = true;
            lb筛选.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb筛选.Location = new Point(157, 80);
            lb筛选.Margin = new Padding(2, 0, 2, 0);
            lb筛选.Name = "lb筛选";
            lb筛选.Size = new Size(69, 19);
            lb筛选.TabIndex = 0;
            lb筛选.Text = "筛选：";
            // 
            // lb欢迎来到选课界面
            // 
            lb欢迎来到选课界面.AutoSize = true;
            lb欢迎来到选课界面.Font = new Font("宋体", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb欢迎来到选课界面.Location = new Point(329, 31);
            lb欢迎来到选课界面.Margin = new Padding(2, 0, 2, 0);
            lb欢迎来到选课界面.Name = "lb欢迎来到选课界面";
            lb欢迎来到选课界面.Size = new Size(202, 24);
            lb欢迎来到选课界面.TabIndex = 1;
            lb欢迎来到选课界面.Text = "欢迎来到选课界面";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(235, 81);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 2;
            label1.Text = "教师：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(436, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 3;
            label2.Text = "学院：";
            // 
            // cb教师
            // 
            cb教师.FormattingEnabled = true;
            cb教师.Location = new Point(296, 81);
            cb教师.Margin = new Padding(2, 3, 2, 3);
            cb教师.Name = "cb教师";
            cb教师.Size = new Size(99, 25);
            cb教师.TabIndex = 4;
            cb教师.SelectedIndexChanged += cb教师_SelectedIndexChanged;
            // 
            // cb学院
            // 
            cb学院.FormattingEnabled = true;
            cb学院.Location = new Point(505, 81);
            cb学院.Margin = new Padding(2, 3, 2, 3);
            cb学院.Name = "cb学院";
            cb学院.Size = new Size(99, 25);
            cb学院.TabIndex = 5;
            cb学院.SelectedIndexChanged += cb学院_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 退出登录ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(842, 25);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // 退出登录ToolStripMenuItem
            // 
            退出登录ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 信息系统ToolStripMenuItem, 课程系统ToolStripMenuItem, 退出登录ToolStripMenuItem1, 推荐选课ToolStripMenuItem, 查看已投ToolStripMenuItem });
            退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            退出登录ToolStripMenuItem.Size = new Size(68, 21);
            退出登录ToolStripMenuItem.Text = "快速访问";
            退出登录ToolStripMenuItem.Click += 退出登录ToolStripMenuItem_Click;
            // 
            // 信息系统ToolStripMenuItem
            // 
            信息系统ToolStripMenuItem.Name = "信息系统ToolStripMenuItem";
            信息系统ToolStripMenuItem.Size = new Size(180, 22);
            信息系统ToolStripMenuItem.Text = "信息系统";
            // 
            // 课程系统ToolStripMenuItem
            // 
            课程系统ToolStripMenuItem.Name = "课程系统ToolStripMenuItem";
            课程系统ToolStripMenuItem.Size = new Size(180, 22);
            课程系统ToolStripMenuItem.Text = "课程系统";
            // 
            // 退出登录ToolStripMenuItem1
            // 
            退出登录ToolStripMenuItem1.Name = "退出登录ToolStripMenuItem1";
            退出登录ToolStripMenuItem1.Size = new Size(180, 22);
            退出登录ToolStripMenuItem1.Text = "退出登录";
            退出登录ToolStripMenuItem1.Click += 退出登录ToolStripMenuItem1_Click;
            // 
            // 推荐选课ToolStripMenuItem
            // 
            推荐选课ToolStripMenuItem.Name = "推荐选课ToolStripMenuItem";
            推荐选课ToolStripMenuItem.Size = new Size(180, 22);
            推荐选课ToolStripMenuItem.Text = "推荐选课";
            推荐选课ToolStripMenuItem.Click += 推荐选课ToolStripMenuItem_Click;
            // 
            // 查看已投ToolStripMenuItem
            // 
            查看已投ToolStripMenuItem.Name = "查看已投ToolStripMenuItem";
            查看已投ToolStripMenuItem.Size = new Size(180, 22);
            查看已投ToolStripMenuItem.Text = "查看已投";
            查看已投ToolStripMenuItem.Click += 查看已投ToolStripMenuItem_Click;
            // 
            // dg课程列表
            // 
            dg课程列表.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg课程列表.Columns.AddRange(new DataGridViewColumn[] { 课号, 课名, 开始时间, 持续时间, 教师, 教室, 学院, 人数, 已选人数 });
            dg课程列表.Location = new Point(9, 136);
            dg课程列表.Margin = new Padding(2, 3, 2, 3);
            dg课程列表.Name = "dg课程列表";
            dg课程列表.RowHeadersWidth = 51;
            dg课程列表.RowTemplate.Height = 29;
            dg课程列表.Size = new Size(819, 271);
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
            // 人数
            // 
            人数.HeaderText = "人数";
            人数.Name = "人数";
            // 
            // 已选人数
            // 
            已选人数.HeaderText = "已选人数";
            已选人数.Name = "已选人数";
            // 
            // bt选课
            // 
            bt选课.Location = new Point(312, 412);
            bt选课.Margin = new Padding(2, 3, 2, 3);
            bt选课.Name = "bt选课";
            bt选课.Size = new Size(245, 26);
            bt选课.TabIndex = 9;
            bt选课.Text = "选课";
            bt选课.UseVisualStyleBackColor = true;
            bt选课.Click += bt选课_Click;
            // 
            // lb欢迎同学
            // 
            lb欢迎同学.AutoSize = true;
            lb欢迎同学.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb欢迎同学.Location = new Point(672, 31);
            lb欢迎同学.Margin = new Padding(2, 0, 2, 0);
            lb欢迎同学.Name = "lb欢迎同学";
            lb欢迎同学.Size = new Size(74, 21);
            lb欢迎同学.TabIndex = 10;
            lb欢迎同学.Text = "欢迎同学";
            lb欢迎同学.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt刷新
            // 
            bt刷新.Location = new Point(9, 102);
            bt刷新.Margin = new Padding(2, 3, 2, 3);
            bt刷新.Name = "bt刷新";
            bt刷新.Size = new Size(71, 29);
            bt刷新.TabIndex = 11;
            bt刷新.Text = "刷新";
            bt刷新.UseVisualStyleBackColor = true;
            bt刷新.Click += bt刷新_Click;
            // 
            // lb剩余学分
            // 
            lb剩余学分.AutoSize = true;
            lb剩余学分.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb剩余学分.Location = new Point(712, 107);
            lb剩余学分.Margin = new Padding(2, 0, 2, 0);
            lb剩余学分.Name = "lb剩余学分";
            lb剩余学分.Size = new Size(119, 16);
            lb剩余学分.TabIndex = 12;
            lb剩余学分.Text = "你还剩多少学分";
            lb剩余学分.Click += lb剩余学分_Click;
            // 
            // textBox_inputScore
            // 
            textBox_inputScore.Location = new Point(102, 418);
            textBox_inputScore.Name = "textBox_inputScore";
            textBox_inputScore.Size = new Size(100, 23);
            textBox_inputScore.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 421);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 14;
            label3.Text = "输入分数";
            // 
            // 选课界面
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 471);
            Controls.Add(label3);
            Controls.Add(textBox_inputScore);
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
            Margin = new Padding(2, 3, 2, 3);
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
        private DataGridViewTextBoxColumn 人数;
        private DataGridViewTextBoxColumn 已选人数;
        private TextBox textBox_inputScore;
        private Label label3;
        private ToolStripMenuItem 推荐选课ToolStripMenuItem;
        private ToolStripMenuItem 查看已投ToolStripMenuItem;
    }
}