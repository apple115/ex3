namespace WinFormsApp1
{
    partial class 添加学生
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
            lb学号 = new Label();
            lb姓名 = new Label();
            lb专业 = new Label();
            lb班级 = new Label();
            tb学号 = new TextBox();
            tb姓名 = new TextBox();
            tb班级 = new TextBox();
            cb专业 = new ComboBox();
            lb输入学生信息 = new Label();
            bt添加学生 = new Button();
            SuspendLayout();
            // 
            // lb学号
            // 
            lb学号.AutoSize = true;
            lb学号.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb学号.Location = new Point(184, 117);
            lb学号.Name = "lb学号";
            lb学号.Size = new Size(82, 23);
            lb学号.TabIndex = 0;
            lb学号.Text = "学号：";
            // 
            // lb姓名
            // 
            lb姓名.AutoSize = true;
            lb姓名.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb姓名.Location = new Point(184, 173);
            lb姓名.Name = "lb姓名";
            lb姓名.Size = new Size(82, 23);
            lb姓名.TabIndex = 1;
            lb姓名.Text = "姓名：";
            // 
            // lb专业
            // 
            lb专业.AutoSize = true;
            lb专业.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb专业.Location = new Point(184, 237);
            lb专业.Name = "lb专业";
            lb专业.Size = new Size(82, 23);
            lb专业.TabIndex = 2;
            lb专业.Text = "专业：";
            // 
            // lb班级
            // 
            lb班级.AutoSize = true;
            lb班级.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb班级.Location = new Point(184, 308);
            lb班级.Name = "lb班级";
            lb班级.Size = new Size(82, 23);
            lb班级.TabIndex = 3;
            lb班级.Text = "班级：";
            // 
            // tb学号
            // 
            tb学号.Location = new Point(295, 113);
            tb学号.Name = "tb学号";
            tb学号.Size = new Size(276, 27);
            tb学号.TabIndex = 4;
            // 
            // tb姓名
            // 
            tb姓名.Location = new Point(295, 169);
            tb姓名.Name = "tb姓名";
            tb姓名.Size = new Size(276, 27);
            tb姓名.TabIndex = 5;
            // 
            // tb班级
            // 
            tb班级.Location = new Point(295, 304);
            tb班级.Name = "tb班级";
            tb班级.Size = new Size(276, 27);
            tb班级.TabIndex = 6;
            // 
            // cb专业
            // 
            cb专业.FormattingEnabled = true;
            cb专业.Location = new Point(295, 238);
            cb专业.Name = "cb专业";
            cb专业.Size = new Size(276, 28);
            cb专业.TabIndex = 7;
            // 
            // lb输入学生信息
            // 
            lb输入学生信息.AutoSize = true;
            lb输入学生信息.Font = new Font("楷体", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb输入学生信息.Location = new Point(295, 32);
            lb输入学生信息.Name = "lb输入学生信息";
            lb输入学生信息.Size = new Size(283, 37);
            lb输入学生信息.TabIndex = 8;
            lb输入学生信息.Text = "请输入学生信息";
            // 
            // bt添加学生
            // 
            bt添加学生.Location = new Point(295, 358);
            bt添加学生.Name = "bt添加学生";
            bt添加学生.Size = new Size(276, 63);
            bt添加学生.TabIndex = 9;
            bt添加学生.Text = "添加";
            bt添加学生.UseVisualStyleBackColor = true;
            bt添加学生.Click += bt添加学生_Click;
            // 
            // 添加学生
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt添加学生);
            Controls.Add(lb输入学生信息);
            Controls.Add(cb专业);
            Controls.Add(tb班级);
            Controls.Add(tb姓名);
            Controls.Add(tb学号);
            Controls.Add(lb班级);
            Controls.Add(lb专业);
            Controls.Add(lb姓名);
            Controls.Add(lb学号);
            Name = "添加学生";
            Text = "添加学生";
            FormClosing += 添加学生_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb学号;
        private Label lb姓名;
        private Label lb专业;
        private Label lb班级;
        private TextBox tb学号;
        private TextBox tb姓名;
        private TextBox tb班级;
        private ComboBox cb专业;
        private Label lb输入学生信息;
        private Button bt添加学生;
    }
}