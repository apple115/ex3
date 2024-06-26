namespace WinFormsApp1
{
    partial class 课程表
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
            bt导出课程表 = new Button();
            cb课程表 = new ComboBox();
            label1 = new Label();
            listView1 = new ListView();
            Timeuiop = new ColumnHeader();
            第一节 = new ColumnHeader();
            第二节 = new ColumnHeader();
            第三节 = new ColumnHeader();
            第四节 = new ColumnHeader();
            第五节 = new ColumnHeader();
            SuspendLayout();
            // 
            // bt导出课程表
            // 
            bt导出课程表.Location = new Point(345, 490);
            bt导出课程表.Margin = new Padding(2, 3, 2, 3);
            bt导出课程表.Name = "bt导出课程表";
            bt导出课程表.Size = new Size(173, 38);
            bt导出课程表.TabIndex = 1;
            bt导出课程表.Text = "导出课程表";
            bt导出课程表.UseVisualStyleBackColor = true;
            // 
            // cb课程表
            // 
            cb课程表.FormattingEnabled = true;
            cb课程表.Location = new Point(345, 25);
            cb课程表.Margin = new Padding(2, 3, 2, 3);
            cb课程表.Name = "cb课程表";
            cb课程表.Size = new Size(118, 25);
            cb课程表.TabIndex = 2;
            cb课程表.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(287, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 16);
            label1.TabIndex = 3;
            label1.Text = "周次：";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Timeuiop, 第一节, 第二节, 第三节, 第四节, 第五节 });
            listView1.Location = new Point(25, 83);
            listView1.Margin = new Padding(2, 3, 2, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(837, 368);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            // 课程表
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 611);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(cb课程表);
            Controls.Add(bt导出课程表);
            Margin = new Padding(2, 3, 2, 3);
            Name = "课程表";
            Text = "课程表";
            Load += 课程表_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt导出课程表;
        private ComboBox cb课程表;
        private Label label1;
        private ListView listView1;
        private ColumnHeader 第一节;
        private ColumnHeader 第二节;
        private ColumnHeader 第三节;
        private ColumnHeader 第四节;
        private ColumnHeader 第五节;
        private ColumnHeader Timeuiop;
    }
}