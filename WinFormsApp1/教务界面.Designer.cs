namespace WinFormsApp1
{
    partial class 教务界面
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
            lb欢迎教务 = new Label();
            dg教务课程列表 = new DataGridView();
            课号 = new DataGridViewTextBoxColumn();
            课名 = new DataGridViewTextBoxColumn();
            开始时间 = new DataGridViewTextBoxColumn();
            持续时间 = new DataGridViewTextBoxColumn();
            教师 = new DataGridViewTextBoxColumn();
            教室 = new DataGridViewTextBoxColumn();
            学院 = new DataGridViewTextBoxColumn();
            星期 = new DataGridViewTextBoxColumn();
            节次 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            快速访问ToolStripMenuItem = new ToolStripMenuItem();
            退出登录ToolStripMenuItem = new ToolStripMenuItem();
            bt编辑课程 = new Button();
            bt添加课程 = new Button();
            bt删除课程 = new Button();
            button_stopSelectCourse = new Button();
            button_courseTime = new Button();
            ((System.ComponentModel.ISupportInitialize)dg教务课程列表).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lb欢迎教务
            // 
            lb欢迎教务.AutoSize = true;
            lb欢迎教务.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb欢迎教务.Location = new Point(295, 42);
            lb欢迎教务.Margin = new Padding(2, 0, 2, 0);
            lb欢迎教务.Name = "lb欢迎教务";
            lb欢迎教务.Size = new Size(202, 24);
            lb欢迎教务.TabIndex = 5;
            lb欢迎教务.Text = "欢迎来到教务界面";
            // 
            // dg教务课程列表
            // 
            dg教务课程列表.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg教务课程列表.Columns.AddRange(new DataGridViewColumn[] { 课号, 课名, 开始时间, 持续时间, 教师, 教室, 学院, 星期, 节次 });
            dg教务课程列表.Location = new Point(23, 116);
            dg教务课程列表.Margin = new Padding(2, 3, 2, 3);
            dg教务课程列表.Name = "dg教务课程列表";
            dg教务课程列表.ReadOnly = true;
            dg教务课程列表.RowHeadersWidth = 51;
            dg教务课程列表.RowTemplate.Height = 29;
            dg教务课程列表.Size = new Size(920, 279);
            dg教务课程列表.TabIndex = 4;
            dg教务课程列表.CellContentClick += dg教务课程列表_CellContentClick;
            dg教务课程列表.CellDoubleClick += dg教务课程列表_CellDoubleClick;
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
            // 星期
            // 
            星期.HeaderText = "星期";
            星期.MinimumWidth = 6;
            星期.Name = "星期";
            星期.ReadOnly = true;
            星期.Width = 125;
            // 
            // 节次
            // 
            节次.HeaderText = "节次";
            节次.MinimumWidth = 6;
            节次.Name = "节次";
            节次.ReadOnly = true;
            节次.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 快速访问ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(957, 25);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // 快速访问ToolStripMenuItem
            // 
            快速访问ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 退出登录ToolStripMenuItem });
            快速访问ToolStripMenuItem.Name = "快速访问ToolStripMenuItem";
            快速访问ToolStripMenuItem.Size = new Size(68, 21);
            快速访问ToolStripMenuItem.Text = "快速访问";
            // 
            // 退出登录ToolStripMenuItem
            // 
            退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            退出登录ToolStripMenuItem.Size = new Size(124, 22);
            退出登录ToolStripMenuItem.Text = "退出登录";
            // 
            // bt编辑课程
            // 
            bt编辑课程.Location = new Point(151, 77);
            bt编辑课程.Margin = new Padding(2, 3, 2, 3);
            bt编辑课程.Name = "bt编辑课程";
            bt编辑课程.Size = new Size(94, 33);
            bt编辑课程.TabIndex = 8;
            bt编辑课程.Text = "修改信息";
            bt编辑课程.UseVisualStyleBackColor = true;
            bt编辑课程.Click += bt编辑课程_Click;
            // 
            // bt添加课程
            // 
            bt添加课程.Location = new Point(23, 77);
            bt添加课程.Margin = new Padding(2, 3, 2, 3);
            bt添加课程.Name = "bt添加课程";
            bt添加课程.Size = new Size(94, 33);
            bt添加课程.TabIndex = 9;
            bt添加课程.Text = "添加课程";
            bt添加课程.UseVisualStyleBackColor = true;
            bt添加课程.Click += bt添加课程_Click;
            // 
            // bt删除课程
            // 
            bt删除课程.Location = new Point(278, 77);
            bt删除课程.Margin = new Padding(2, 3, 2, 3);
            bt删除课程.Name = "bt删除课程";
            bt删除课程.Size = new Size(94, 33);
            bt删除课程.TabIndex = 10;
            bt删除课程.Text = "删除课程";
            bt删除课程.UseVisualStyleBackColor = true;
            bt删除课程.Click += bt删除课程_Click;
            // 
            // button_stopSelectCourse
            // 
            button_stopSelectCourse.Location = new Point(413, 77);
            button_stopSelectCourse.Name = "button_stopSelectCourse";
            button_stopSelectCourse.Size = new Size(94, 33);
            button_stopSelectCourse.TabIndex = 11;
            button_stopSelectCourse.Text = "停止选课";
            button_stopSelectCourse.UseVisualStyleBackColor = true;
            button_stopSelectCourse.Click += button_stopSelectCourse_Click;
            // 
            // button_courseTime
            // 
            button_courseTime.Location = new Point(542, 77);
            button_courseTime.Name = "button_courseTime";
            button_courseTime.Size = new Size(99, 33);
            button_courseTime.TabIndex = 12;
            button_courseTime.Text = "分配时间";
            button_courseTime.UseVisualStyleBackColor = true;
            button_courseTime.Click += button_courseTime_Click;
            // 
            // 教务界面
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 470);
            Controls.Add(button_courseTime);
            Controls.Add(button_stopSelectCourse);
            Controls.Add(bt删除课程);
            Controls.Add(bt添加课程);
            Controls.Add(bt编辑课程);
            Controls.Add(lb欢迎教务);
            Controls.Add(dg教务课程列表);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "教务界面";
            Text = "教务界面";
            FormClosing += 教务界面_FormClosing;
            Load += 教务界面_Load;
            ((System.ComponentModel.ISupportInitialize)dg教务课程列表).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb欢迎教务;
        private DataGridView dg教务课程列表;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 快速访问ToolStripMenuItem;
        private ToolStripMenuItem 退出登录ToolStripMenuItem;
        private Button bt编辑课程;
        private Button bt添加课程;
        private Button bt删除课程;
        private Button button_stopSelectCourse;
        private DataGridViewTextBoxColumn 课号;
        private DataGridViewTextBoxColumn 课名;
        private DataGridViewTextBoxColumn 开始时间;
        private DataGridViewTextBoxColumn 持续时间;
        private DataGridViewTextBoxColumn 教师;
        private DataGridViewTextBoxColumn 教室;
        private DataGridViewTextBoxColumn 学院;
        private DataGridViewTextBoxColumn 星期;
        private DataGridViewTextBoxColumn 节次;
        private Button button_courseTime;
    }
}