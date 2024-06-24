namespace WinFormsApp1
{
    partial class CourseRecommendationform
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
            courseSelect = new Button();
            label1 = new Label();
            button_refresh = new Button();
            dataGridView_courseRecommend = new DataGridView();
            label2 = new Label();
            textBox_inputScore = new TextBox();
            课号 = new DataGridViewTextBoxColumn();
            课名 = new DataGridViewTextBoxColumn();
            开始时间 = new DataGridViewTextBoxColumn();
            持续时间 = new DataGridViewTextBoxColumn();
            教师 = new DataGridViewTextBoxColumn();
            教室 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            选课人数 = new DataGridViewTextBoxColumn();
            已选人数 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_courseRecommend).BeginInit();
            SuspendLayout();
            // 
            // courseSelect
            // 
            courseSelect.Location = new Point(410, 478);
            courseSelect.Margin = new Padding(2, 3, 2, 3);
            courseSelect.Name = "courseSelect";
            courseSelect.Size = new Size(73, 25);
            courseSelect.TabIndex = 1;
            courseSelect.Text = "选课";
            courseSelect.UseVisualStyleBackColor = true;
            courseSelect.Click += courseSelect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 21);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 2;
            label1.Text = "推荐选课";
            label1.Click += label1_Click;
            // 
            // button_refresh
            // 
            button_refresh.Location = new Point(19, 63);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(75, 23);
            button_refresh.TabIndex = 3;
            button_refresh.Text = "刷新";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // dataGridView_courseRecommend
            // 
            dataGridView_courseRecommend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_courseRecommend.Columns.AddRange(new DataGridViewColumn[] { 课号, 课名, 开始时间, 持续时间, 教师, 教室, Column1, 选课人数, 已选人数 });
            dataGridView_courseRecommend.Location = new Point(19, 92);
            dataGridView_courseRecommend.Name = "dataGridView_courseRecommend";
            dataGridView_courseRecommend.RowHeadersWidth = 51;
            dataGridView_courseRecommend.RowTemplate.Height = 25;
            dataGridView_courseRecommend.Size = new Size(871, 363);
            dataGridView_courseRecommend.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 481);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 5;
            label2.Text = "输入分数";
            // 
            // textBox_inputScore
            // 
            textBox_inputScore.Location = new Point(126, 479);
            textBox_inputScore.Margin = new Padding(2, 3, 2, 3);
            textBox_inputScore.Name = "textBox_inputScore";
            textBox_inputScore.Size = new Size(98, 23);
            textBox_inputScore.TabIndex = 6;
            // 
            // 课号
            // 
            课号.HeaderText = "课号";
            课号.MinimumWidth = 6;
            课号.Name = "课号";
            课号.Width = 125;
            // 
            // 课名
            // 
            课名.HeaderText = "课名";
            课名.MinimumWidth = 6;
            课名.Name = "课名";
            课名.Width = 125;
            // 
            // 开始时间
            // 
            开始时间.HeaderText = "开始时间";
            开始时间.MinimumWidth = 6;
            开始时间.Name = "开始时间";
            开始时间.Width = 125;
            // 
            // 持续时间
            // 
            持续时间.HeaderText = "持续时间";
            持续时间.MinimumWidth = 6;
            持续时间.Name = "持续时间";
            持续时间.Width = 125;
            // 
            // 教师
            // 
            教师.HeaderText = "教师";
            教师.MinimumWidth = 6;
            教师.Name = "教师";
            教师.Width = 125;
            // 
            // 教室
            // 
            教室.HeaderText = "教室";
            教室.MinimumWidth = 6;
            教室.Name = "教室";
            教室.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "学院";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // 选课人数
            // 
            选课人数.HeaderText = "人数";
            选课人数.Name = "选课人数";
            // 
            // 已选人数
            // 
            已选人数.HeaderText = "已选人数";
            已选人数.Name = "已选人数";
            // 
            // CourseRecommendationform
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 525);
            Controls.Add(textBox_inputScore);
            Controls.Add(label2);
            Controls.Add(dataGridView_courseRecommend);
            Controls.Add(button_refresh);
            Controls.Add(label1);
            Controls.Add(courseSelect);
            Margin = new Padding(2, 3, 2, 3);
            Name = "CourseRecommendationform";
            Text = "CourseRecommendationform";
            Load += CourseRecommendationform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_courseRecommend).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button courseSelect;
        private Label label1;
        private Button button_refresh;
        private DataGridView dataGridView_courseRecommend;
        private Label label2;
        private TextBox textBox_inputScore;
        private DataGridViewTextBoxColumn 课号;
        private DataGridViewTextBoxColumn 课名;
        private DataGridViewTextBoxColumn 开始时间;
        private DataGridViewTextBoxColumn 持续时间;
        private DataGridViewTextBoxColumn 教师;
        private DataGridViewTextBoxColumn 教室;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn 选课人数;
        private DataGridViewTextBoxColumn 已选人数;
    }
}