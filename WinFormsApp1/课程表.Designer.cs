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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "" }, -1, Color.Empty, SystemColors.HotTrack, null);
            dataGridView1 = new DataGridView();
            Time_co = new DataGridViewTextBoxColumn();
            Mon_co = new DataGridViewTextBoxColumn();
            Tue_co = new DataGridViewTextBoxColumn();
            Wed_co = new DataGridViewTextBoxColumn();
            Thr__co = new DataGridViewTextBoxColumn();
            Fri_co = new DataGridViewTextBoxColumn();
            Sat_co = new DataGridViewTextBoxColumn();
            Sun_co = new DataGridViewTextBoxColumn();
            bt导出课程表 = new Button();
            cb课程表 = new ComboBox();
            label1 = new Label();
            listView1 = new ListView();
            Timeuiop = new ColumnHeader();
            星期一列 = new ColumnHeader();
            星期二列 = new ColumnHeader();
            星期三列 = new ColumnHeader();
            星期四列 = new ColumnHeader();
            星期五列 = new ColumnHeader();
            星期六列 = new ColumnHeader();
            星期日列 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 75;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Time_co, Mon_co, Tue_co, Wed_co, Thr__co, Fri_co, Sat_co, Sun_co });
            dataGridView1.Location = new Point(12, 360);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(108, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Time_co
            // 
            Time_co.FillWeight = 50F;
            Time_co.HeaderText = "节次";
            Time_co.MinimumWidth = 6;
            Time_co.Name = "Time_co";
            Time_co.Width = 50;
            // 
            // Mon_co
            // 
            Mon_co.HeaderText = "星期一";
            Mon_co.MinimumWidth = 6;
            Mon_co.Name = "Mon_co";
            Mon_co.Width = 125;
            // 
            // Tue_co
            // 
            Tue_co.HeaderText = "星期二";
            Tue_co.MinimumWidth = 6;
            Tue_co.Name = "Tue_co";
            Tue_co.Width = 125;
            // 
            // Wed_co
            // 
            Wed_co.HeaderText = "星期三";
            Wed_co.MinimumWidth = 6;
            Wed_co.Name = "Wed_co";
            Wed_co.Width = 125;
            // 
            // Thr__co
            // 
            Thr__co.HeaderText = "星期四";
            Thr__co.MinimumWidth = 6;
            Thr__co.Name = "Thr__co";
            Thr__co.Width = 125;
            // 
            // Fri_co
            // 
            Fri_co.HeaderText = "星期五";
            Fri_co.MinimumWidth = 6;
            Fri_co.Name = "Fri_co";
            Fri_co.Width = 125;
            // 
            // Sat_co
            // 
            Sat_co.HeaderText = "星期六";
            Sat_co.MinimumWidth = 6;
            Sat_co.Name = "Sat_co";
            Sat_co.Width = 125;
            // 
            // Sun_co
            // 
            Sun_co.HeaderText = "星期日";
            Sun_co.MinimumWidth = 6;
            Sun_co.Name = "Sun_co";
            Sun_co.Width = 125;
            // 
            // bt导出课程表
            // 
            bt导出课程表.Location = new Point(286, 539);
            bt导出课程表.Name = "bt导出课程表";
            bt导出课程表.Size = new Size(222, 45);
            bt导出课程表.TabIndex = 1;
            bt导出课程表.Text = "导出课程表";
            bt导出课程表.UseVisualStyleBackColor = true;
            // 
            // cb课程表
            // 
            cb课程表.FormattingEnabled = true;
            cb课程表.Location = new Point(247, 23);
            cb课程表.Name = "cb课程表";
            cb课程表.Size = new Size(151, 28);
            cb课程表.TabIndex = 2;
            cb课程表.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(172, 25);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "周次：";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Timeuiop, 星期一列, 星期二列, 星期三列, 星期四列, 星期五列, 星期六列, 星期日列 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(138, 99);
            listView1.Name = "listView1";
            listView1.Size = new Size(633, 411);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Timeuiop
            // 
            Timeuiop.Text = "节次";
            // 
            // 星期一列
            // 
            星期一列.Text = "星期一";
            星期一列.Width = 75;
            // 
            // 星期二列
            // 
            星期二列.Text = "星期二";
            星期二列.Width = 75;
            // 
            // 星期三列
            // 
            星期三列.Text = "星期三";
            星期三列.Width = 75;
            // 
            // 星期四列
            // 
            星期四列.Text = "星期四";
            星期四列.Width = 75;
            // 
            // 星期五列
            // 
            星期五列.Text = "星期五";
            星期五列.Width = 75;
            // 
            // 星期六列
            // 
            星期六列.Text = "星期六";
            星期六列.Width = 75;
            // 
            // 星期日列
            // 
            星期日列.Text = "星期日";
            星期日列.Width = 75;
            // 
            // 课程表
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 590);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(cb课程表);
            Controls.Add(bt导出课程表);
            Controls.Add(dataGridView1);
            Name = "课程表";
            Text = "课程表";
            Load += 课程表_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Time_co;
        private DataGridViewTextBoxColumn Mon_co;
        private DataGridViewTextBoxColumn Tue_co;
        private DataGridViewTextBoxColumn Wed_co;
        private DataGridViewTextBoxColumn Thr__co;
        private DataGridViewTextBoxColumn Fri_co;
        private DataGridViewTextBoxColumn Sat_co;
        private DataGridViewTextBoxColumn Sun_co;
        private Button bt导出课程表;
        private ComboBox cb课程表;
        private Label label1;
        private ListView listView1;
        private ColumnHeader 星期一列;
        private ColumnHeader 星期二列;
        private ColumnHeader 星期三列;
        private ColumnHeader 星期四列;
        private ColumnHeader 星期五列;
        private ColumnHeader 星期六列;
        private ColumnHeader 星期日列;
        private ColumnHeader Timeuiop;
    }
}