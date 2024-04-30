namespace WinFormsApp1
{
    partial class 学生列表
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
            dg学生列表 = new DataGridView();
            学号 = new DataGridViewTextBoxColumn();
            姓名 = new DataGridViewTextBoxColumn();
            专业 = new DataGridViewTextBoxColumn();
            班级 = new DataGridViewTextBoxColumn();
            bt添加学生 = new Button();
            bt删除学生 = new Button();
            lb显示课程 = new Label();
            lb课号 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg学生列表).BeginInit();
            SuspendLayout();
            // 
            // dg学生列表
            // 
            dg学生列表.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg学生列表.Columns.AddRange(new DataGridViewColumn[] { 学号, 姓名, 专业, 班级 });
            dg学生列表.Location = new Point(122, 92);
            dg学生列表.Name = "dg学生列表";
            dg学生列表.ReadOnly = true;
            dg学生列表.RowHeadersWidth = 51;
            dg学生列表.RowTemplate.Height = 29;
            dg学生列表.Size = new Size(553, 274);
            dg学生列表.TabIndex = 0;
            // 
            // 学号
            // 
            学号.HeaderText = "学号";
            学号.MinimumWidth = 6;
            学号.Name = "学号";
            学号.ReadOnly = true;
            学号.Width = 125;
            // 
            // 姓名
            // 
            姓名.HeaderText = "姓名";
            姓名.MinimumWidth = 6;
            姓名.Name = "姓名";
            姓名.ReadOnly = true;
            姓名.Width = 125;
            // 
            // 专业
            // 
            专业.HeaderText = "专业";
            专业.MinimumWidth = 6;
            专业.Name = "专业";
            专业.ReadOnly = true;
            专业.Width = 125;
            // 
            // 班级
            // 
            班级.HeaderText = "班级";
            班级.MinimumWidth = 6;
            班级.Name = "班级";
            班级.ReadOnly = true;
            班级.Width = 125;
            // 
            // bt添加学生
            // 
            bt添加学生.Location = new Point(149, 388);
            bt添加学生.Name = "bt添加学生";
            bt添加学生.Size = new Size(179, 43);
            bt添加学生.TabIndex = 1;
            bt添加学生.Text = "添加学生";
            bt添加学生.UseVisualStyleBackColor = true;
            bt添加学生.Click += bt添加学生_Click;
            // 
            // bt删除学生
            // 
            bt删除学生.Location = new Point(466, 388);
            bt删除学生.Name = "bt删除学生";
            bt删除学生.Size = new Size(179, 43);
            bt删除学生.TabIndex = 2;
            bt删除学生.Text = "删除学生";
            bt删除学生.UseVisualStyleBackColor = true;
            bt删除学生.Click += bt删除学生_Click;
            // 
            // lb显示课程
            // 
            lb显示课程.AutoSize = true;
            lb显示课程.Font = new Font("楷体", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb显示课程.Location = new Point(304, 27);
            lb显示课程.Name = "lb显示课程";
            lb显示课程.Size = new Size(93, 37);
            lb显示课程.TabIndex = 3;
            lb显示课程.Text = "课程";
            // 
            // lb课号
            // 
            lb课号.AutoSize = true;
            lb课号.Font = new Font("楷体", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb课号.Location = new Point(403, 27);
            lb课号.Name = "lb课号";
            lb课号.Size = new Size(93, 37);
            lb课号.TabIndex = 4;
            lb课号.Text = "课号";
            // 
            // 学生列表
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb课号);
            Controls.Add(lb显示课程);
            Controls.Add(bt删除学生);
            Controls.Add(bt添加学生);
            Controls.Add(dg学生列表);
            Name = "学生列表";
            Text = "学生列表";
            FormClosing += 学生列表_FormClosing;
            Load += 学生列表_Load;
            ((System.ComponentModel.ISupportInitialize)dg学生列表).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg学生列表;
        private DataGridViewTextBoxColumn 学号;
        private DataGridViewTextBoxColumn 姓名;
        private DataGridViewTextBoxColumn 专业;
        private DataGridViewTextBoxColumn 班级;
        private Button bt添加学生;
        private Button bt删除学生;
        private Label lb显示课程;
        private Label lb课号;
    }
}