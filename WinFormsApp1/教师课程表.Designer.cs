namespace WinFormsApp1
{
    partial class 教师课程表
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
            listView1 = new ListView();
            Timeuiop = new ColumnHeader();
            第一节 = new ColumnHeader();
            第二节 = new ColumnHeader();
            第三节 = new ColumnHeader();
            第四节 = new ColumnHeader();
            第五节 = new ColumnHeader();
            label1 = new Label();
            cb课程表 = new ComboBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Timeuiop, 第一节, 第二节, 第三节, 第四节, 第五节 });
            listView1.Location = new Point(14, 65);
            listView1.Margin = new Padding(2, 3, 2, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(837, 368);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Timeuiop
            // 
            Timeuiop.Text = "节次";
            // 
            // 第一节
            // 
            第一节.Text = "第一节";
            第一节.Width = 150;
            // 
            // 第二节
            // 
            第二节.Text = "第二节";
            第二节.Width = 150;
            // 
            // 第三节
            // 
            第三节.Text = "第三节";
            第三节.Width = 150;
            // 
            // 第四节
            // 
            第四节.Text = "第四节";
            第四节.Width = 150;
            // 
            // 第五节
            // 
            第五节.Text = "第五节";
            第五节.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(291, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 16);
            label1.TabIndex = 7;
            label1.Text = "周次：";
            // 
            // cb课程表
            // 
            cb课程表.FormattingEnabled = true;
            cb课程表.Location = new Point(349, 12);
            cb课程表.Margin = new Padding(2, 3, 2, 3);
            cb课程表.Name = "cb课程表";
            cb课程表.Size = new Size(118, 25);
            cb课程表.TabIndex = 6;
            cb课程表.SelectedIndexChanged += cb课程表_SelectedIndexChanged_1;
            // 
            // 教师课程表
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 480);
            Controls.Add(label1);
            Controls.Add(cb课程表);
            Controls.Add(listView1);
            Name = "教师课程表";
            Text = "教师课程表";
            Load += 教师课程表_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Timeuiop;
        private ColumnHeader 第一节;
        private ColumnHeader 第二节;
        private ColumnHeader 第三节;
        private ColumnHeader 第四节;
        private ColumnHeader 第五节;
        private Label label1;
        private ComboBox cb课程表;
    }
}