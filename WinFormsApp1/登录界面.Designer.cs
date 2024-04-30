namespace WinFormsApp1
{
    partial class 登录界面
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb校园选课系统 = new Label();
            lb用户名 = new Label();
            label1 = new Label();
            tb用户名 = new TextBox();
            tb密码 = new TextBox();
            bt登录 = new Button();
            SuspendLayout();
            // 
            // lb校园选课系统
            // 
            lb校园选课系统.AutoSize = true;
            lb校园选课系统.Font = new Font("楷体", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lb校园选课系统.Location = new Point(295, 103);
            lb校园选课系统.Name = "lb校园选课系统";
            lb校园选课系统.Size = new Size(257, 40);
            lb校园选课系统.TabIndex = 0;
            lb校园选课系统.Text = "校园选课系统";
            // 
            // lb用户名
            // 
            lb用户名.AutoSize = true;
            lb用户名.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb用户名.Location = new Point(129, 202);
            lb用户名.Name = "lb用户名";
            lb用户名.Size = new Size(106, 23);
            lb用户名.TabIndex = 1;
            lb用户名.Text = "用户名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 276);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 2;
            label1.Text = "密码：";
            // 
            // tb用户名
            // 
            tb用户名.Location = new Point(241, 198);
            tb用户名.Name = "tb用户名";
            tb用户名.Size = new Size(377, 27);
            tb用户名.TabIndex = 3;
            // 
            // tb密码
            // 
            tb密码.Location = new Point(241, 277);
            tb密码.Name = "tb密码";
            tb密码.Size = new Size(377, 27);
            tb密码.TabIndex = 4;
            tb密码.UseSystemPasswordChar = true;
            // 
            // bt登录
            // 
            bt登录.Location = new Point(331, 332);
            bt登录.Name = "bt登录";
            bt登录.Size = new Size(194, 46);
            bt登录.TabIndex = 5;
            bt登录.Text = "登录";
            bt登录.UseVisualStyleBackColor = true;
            bt登录.Click += bt登录_Click;
            // 
            // 登录界面
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(bt登录);
            Controls.Add(tb密码);
            Controls.Add(tb用户名);
            Controls.Add(label1);
            Controls.Add(lb用户名);
            Controls.Add(lb校园选课系统);
            Name = "登录界面";
            Text = "登录界面";
            FormClosing += 登录界面_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb校园选课系统;
        private Label lb用户名;
        private Label label1;
        private TextBox tb用户名;
        private TextBox tb密码;
        private Button bt登录;
    }
}