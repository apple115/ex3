namespace WinFormsApp1
{
    partial class 教务学生列表
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
            lb课号 = new Label();
            lb显示课程 = new Label();
            dg学生列表 = new DataGridView();
            学号 = new DataGridViewTextBoxColumn();
            姓名 = new DataGridViewTextBoxColumn();
            专业 = new DataGridViewTextBoxColumn();
            班级 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dg学生列表).BeginInit();
            SuspendLayout();
            // 
            // lb课号
            // 
            lb课号.AutoSize = true;
            lb课号.Font = new Font("楷体", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb课号.Location = new Point(405, 54);
            lb课号.Name = "lb课号";
            lb课号.Size = new Size(93, 37);
            lb课号.TabIndex = 7;
            lb课号.Text = "课号";
            // 
            // lb显示课程
            // 
            lb显示课程.AutoSize = true;
            lb显示课程.Font = new Font("楷体", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb显示课程.Location = new Point(306, 54);
            lb显示课程.Name = "lb显示课程";
            lb显示课程.Size = new Size(93, 37);
            lb显示课程.TabIndex = 6;
            lb显示课程.Text = "课程";
            // 
            // dg学生列表
            // 
            dg学生列表.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg学生列表.Columns.AddRange(new DataGridViewColumn[] { 学号, 姓名, 专业, 班级 });
            dg学生列表.Location = new Point(124, 119);
            dg学生列表.Name = "dg学生列表";
            dg学生列表.ReadOnly = true;
            dg学生列表.RowHeadersWidth = 51;
            dg学生列表.RowTemplate.Height = 29;
            dg学生列表.Size = new Size(553, 274);
            dg学生列表.TabIndex = 5;
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
            // 教务学生列表
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb课号);
            Controls.Add(lb显示课程);
            Controls.Add(dg学生列表);
            Name = "教务学生列表";
            Text = "教务学生列表";
            FormClosing += 教务学生列表_FormClosing;
            Load += 教务学生列表_Load;
            ((System.ComponentModel.ISupportInitialize)dg学生列表).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb课号;
        private Label lb显示课程;
        private DataGridView dg学生列表;
        private DataGridViewTextBoxColumn 学号;
        private DataGridViewTextBoxColumn 姓名;
        private DataGridViewTextBoxColumn 专业;
        private DataGridViewTextBoxColumn 班级;
    }
}