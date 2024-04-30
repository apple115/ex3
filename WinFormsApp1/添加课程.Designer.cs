namespace WinFormsApp1
{
    partial class 添加课程
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
            bt添加课程 = new Button();
            lb输入课程信息 = new Label();
            tb持续时间 = new TextBox();
            tb课名 = new TextBox();
            tb课号 = new TextBox();
            lb持续时间 = new Label();
            lb开始时间 = new Label();
            lb课名 = new Label();
            lb课号 = new Label();
            tb开始时间 = new TextBox();
            lb教师 = new Label();
            tb教师 = new TextBox();
            lb教室 = new Label();
            lb学院 = new Label();
            lb学分 = new Label();
            tb教室 = new TextBox();
            tb学院 = new TextBox();
            tb学分 = new TextBox();
            SuspendLayout();
            // 
            // bt添加课程
            // 
            bt添加课程.Location = new Point(288, 626);
            bt添加课程.Name = "bt添加课程";
            bt添加课程.Size = new Size(276, 63);
            bt添加课程.TabIndex = 19;
            bt添加课程.Text = "添加";
            bt添加课程.UseVisualStyleBackColor = true;
            bt添加课程.Click += bt添加课程_Click;
            // 
            // lb输入课程信息
            // 
            lb输入课程信息.AutoSize = true;
            lb输入课程信息.Font = new Font("楷体", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb输入课程信息.Location = new Point(288, 34);
            lb输入课程信息.Name = "lb输入课程信息";
            lb输入课程信息.Size = new Size(283, 37);
            lb输入课程信息.TabIndex = 18;
            lb输入课程信息.Text = "请输入课程信息";
            // 
            // tb持续时间
            // 
            tb持续时间.Location = new Point(288, 297);
            tb持续时间.Name = "tb持续时间";
            tb持续时间.Size = new Size(276, 27);
            tb持续时间.TabIndex = 16;
            // 
            // tb课名
            // 
            tb课名.Location = new Point(288, 171);
            tb课名.Name = "tb课名";
            tb课名.Size = new Size(276, 27);
            tb课名.TabIndex = 15;
            // 
            // tb课号
            // 
            tb课号.Location = new Point(288, 115);
            tb课号.Name = "tb课号";
            tb课号.Size = new Size(276, 27);
            tb课号.TabIndex = 14;
            // 
            // lb持续时间
            // 
            lb持续时间.AutoSize = true;
            lb持续时间.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb持续时间.Location = new Point(129, 301);
            lb持续时间.Name = "lb持续时间";
            lb持续时间.Size = new Size(130, 23);
            lb持续时间.TabIndex = 13;
            lb持续时间.Text = "持续时间：";
            // 
            // lb开始时间
            // 
            lb开始时间.AutoSize = true;
            lb开始时间.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb开始时间.Location = new Point(129, 236);
            lb开始时间.Name = "lb开始时间";
            lb开始时间.Size = new Size(130, 23);
            lb开始时间.TabIndex = 12;
            lb开始时间.Text = "开始时间：";
            // 
            // lb课名
            // 
            lb课名.AutoSize = true;
            lb课名.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb课名.Location = new Point(177, 175);
            lb课名.Name = "lb课名";
            lb课名.Size = new Size(82, 23);
            lb课名.TabIndex = 11;
            lb课名.Text = "课名：";
            // 
            // lb课号
            // 
            lb课号.AutoSize = true;
            lb课号.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb课号.Location = new Point(177, 119);
            lb课号.Name = "lb课号";
            lb课号.Size = new Size(82, 23);
            lb课号.TabIndex = 10;
            lb课号.Text = "课号：";
            // 
            // tb开始时间
            // 
            tb开始时间.Location = new Point(288, 232);
            tb开始时间.Name = "tb开始时间";
            tb开始时间.Size = new Size(276, 27);
            tb开始时间.TabIndex = 20;
            // 
            // lb教师
            // 
            lb教师.AutoSize = true;
            lb教师.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb教师.Location = new Point(177, 366);
            lb教师.Name = "lb教师";
            lb教师.Size = new Size(82, 23);
            lb教师.TabIndex = 21;
            lb教师.Text = "教师：";
            // 
            // tb教师
            // 
            tb教师.Location = new Point(288, 362);
            tb教师.Name = "tb教师";
            tb教师.Size = new Size(276, 27);
            tb教师.TabIndex = 22;
            // 
            // lb教室
            // 
            lb教室.AutoSize = true;
            lb教室.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb教室.Location = new Point(177, 426);
            lb教室.Name = "lb教室";
            lb教室.Size = new Size(82, 23);
            lb教室.TabIndex = 23;
            lb教室.Text = "教室：";
            // 
            // lb学院
            // 
            lb学院.AutoSize = true;
            lb学院.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb学院.Location = new Point(177, 486);
            lb学院.Name = "lb学院";
            lb学院.Size = new Size(82, 23);
            lb学院.TabIndex = 24;
            lb学院.Text = "学院：";
            // 
            // lb学分
            // 
            lb学分.AutoSize = true;
            lb学分.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb学分.Location = new Point(177, 547);
            lb学分.Name = "lb学分";
            lb学分.Size = new Size(82, 23);
            lb学分.TabIndex = 25;
            lb学分.Text = "学分：";
            // 
            // tb教室
            // 
            tb教室.Location = new Point(288, 427);
            tb教室.Name = "tb教室";
            tb教室.Size = new Size(276, 27);
            tb教室.TabIndex = 26;
            // 
            // tb学院
            // 
            tb学院.Location = new Point(288, 487);
            tb学院.Name = "tb学院";
            tb学院.Size = new Size(276, 27);
            tb学院.TabIndex = 27;
            // 
            // tb学分
            // 
            tb学分.Location = new Point(288, 548);
            tb学分.Name = "tb学分";
            tb学分.Size = new Size(276, 27);
            tb学分.TabIndex = 28;
            // 
            // 添加课程
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 753);
            Controls.Add(tb学分);
            Controls.Add(tb学院);
            Controls.Add(tb教室);
            Controls.Add(lb学分);
            Controls.Add(lb学院);
            Controls.Add(lb教室);
            Controls.Add(tb教师);
            Controls.Add(lb教师);
            Controls.Add(tb开始时间);
            Controls.Add(bt添加课程);
            Controls.Add(lb输入课程信息);
            Controls.Add(tb持续时间);
            Controls.Add(tb课名);
            Controls.Add(tb课号);
            Controls.Add(lb持续时间);
            Controls.Add(lb开始时间);
            Controls.Add(lb课名);
            Controls.Add(lb课号);
            Name = "添加课程";
            Text = "添加课程";
            FormClosing += 添加课程_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt添加课程;
        private Label lb输入课程信息;
        private TextBox tb持续时间;
        private TextBox tb课名;
        private TextBox tb课号;
        private Label lb持续时间;
        private Label lb开始时间;
        private Label lb课名;
        private Label lb课号;
        private TextBox tb开始时间;
        private Label lb教师;
        private TextBox tb教师;
        private Label lb教室;
        private Label lb学院;
        private Label lb学分;
        private TextBox tb教室;
        private TextBox tb学院;
        private TextBox tb学分;
    }
}