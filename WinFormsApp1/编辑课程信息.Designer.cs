namespace WinFormsApp1
{
    partial class 编辑课程信息
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
            lb课名 = new Label();
            label2 = new Label();
            label3 = new Label();
            lb教师 = new Label();
            lb教室 = new Label();
            lb学院 = new Label();
            lb学分 = new Label();
            tb课名 = new TextBox();
            tb开始时间 = new TextBox();
            tb持续时间 = new TextBox();
            tb教师 = new TextBox();
            tb教室 = new TextBox();
            tb学院 = new TextBox();
            tb学分 = new TextBox();
            bt保存 = new Button();
            lb保存 = new Label();
            SuspendLayout();
            // 
            // lb课名
            // 
            lb课名.AutoSize = true;
            lb课名.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb课名.Location = new Point(166, 128);
            lb课名.Name = "lb课名";
            lb课名.Size = new Size(82, 23);
            lb课名.TabIndex = 2;
            lb课名.Text = "课名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 180);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 3;
            label2.Text = "开始时间：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 228);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 4;
            label3.Text = "持续时间：";
            // 
            // lb教师
            // 
            lb教师.AutoSize = true;
            lb教师.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb教师.Location = new Point(166, 282);
            lb教师.Name = "lb教师";
            lb教师.Size = new Size(82, 23);
            lb教师.TabIndex = 5;
            lb教师.Text = "教师：";
            // 
            // lb教室
            // 
            lb教室.AutoSize = true;
            lb教室.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb教室.Location = new Point(166, 337);
            lb教室.Name = "lb教室";
            lb教室.Size = new Size(82, 23);
            lb教室.TabIndex = 6;
            lb教室.Text = "教室：";
            // 
            // lb学院
            // 
            lb学院.AutoSize = true;
            lb学院.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb学院.Location = new Point(166, 390);
            lb学院.Name = "lb学院";
            lb学院.Size = new Size(82, 23);
            lb学院.TabIndex = 7;
            lb学院.Text = "学院：";
            // 
            // lb学分
            // 
            lb学分.AutoSize = true;
            lb学分.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb学分.Location = new Point(166, 439);
            lb学分.Name = "lb学分";
            lb学分.Size = new Size(82, 23);
            lb学分.TabIndex = 8;
            lb学分.Text = "学分：";
            // 
            // tb课名
            // 
            tb课名.Location = new Point(290, 129);
            tb课名.Name = "tb课名";
            tb课名.Size = new Size(258, 27);
            tb课名.TabIndex = 9;
            // 
            // tb开始时间
            // 
            tb开始时间.Location = new Point(290, 181);
            tb开始时间.Name = "tb开始时间";
            tb开始时间.Size = new Size(258, 27);
            tb开始时间.TabIndex = 10;
            // 
            // tb持续时间
            // 
            tb持续时间.Location = new Point(290, 229);
            tb持续时间.Name = "tb持续时间";
            tb持续时间.Size = new Size(258, 27);
            tb持续时间.TabIndex = 11;
            // 
            // tb教师
            // 
            tb教师.Location = new Point(290, 283);
            tb教师.Name = "tb教师";
            tb教师.Size = new Size(258, 27);
            tb教师.TabIndex = 12;
            // 
            // tb教室
            // 
            tb教室.Location = new Point(290, 338);
            tb教室.Name = "tb教室";
            tb教室.Size = new Size(258, 27);
            tb教室.TabIndex = 13;
            // 
            // tb学院
            // 
            tb学院.Location = new Point(290, 391);
            tb学院.Name = "tb学院";
            tb学院.Size = new Size(258, 27);
            tb学院.TabIndex = 14;
            // 
            // tb学分
            // 
            tb学分.Location = new Point(290, 440);
            tb学分.Name = "tb学分";
            tb学分.Size = new Size(258, 27);
            tb学分.TabIndex = 15;
            // 
            // bt保存
            // 
            bt保存.Location = new Point(594, 59);
            bt保存.Name = "bt保存";
            bt保存.Size = new Size(133, 49);
            bt保存.TabIndex = 16;
            bt保存.Text = "保存";
            bt保存.UseVisualStyleBackColor = true;
            bt保存.Click += bt保存_Click;
            // 
            // lb保存
            // 
            lb保存.AutoSize = true;
            lb保存.Font = new Font("楷体", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lb保存.Location = new Point(50, 57);
            lb保存.Name = "lb保存";
            lb保存.Size = new Size(397, 37);
            lb保存.TabIndex = 17;
            lb保存.Text = "修改完毕请点击保存键";
            // 
            // 编辑课程信息
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(lb保存);
            Controls.Add(bt保存);
            Controls.Add(tb学分);
            Controls.Add(tb学院);
            Controls.Add(tb教室);
            Controls.Add(tb教师);
            Controls.Add(tb持续时间);
            Controls.Add(tb开始时间);
            Controls.Add(tb课名);
            Controls.Add(lb学分);
            Controls.Add(lb学院);
            Controls.Add(lb教室);
            Controls.Add(lb教师);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lb课名);
            Name = "编辑课程信息";
            Text = "编辑课程信息";
            FormClosing += 编辑课程信息_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb课名;
        private Label label2;
        private Label label3;
        private Label lb教师;
        private Label lb教室;
        private Label lb学院;
        private Label lb学分;
        private TextBox tb课名;
        private TextBox tb开始时间;
        private TextBox tb持续时间;
        private TextBox tb教师;
        private TextBox tb教室;
        private TextBox tb学院;
        private TextBox tb学分;
        private Button bt保存;
        private Label lb保存;
    }
}