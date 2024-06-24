namespace WinFormsApp1
{
    partial class 已投分编辑界面
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
            dataGridView_enrolledCourses = new DataGridView();
            课程编号 = new DataGridViewTextBoxColumn();
            课名 = new DataGridViewTextBoxColumn();
            已投分数 = new DataGridViewTextBoxColumn();
            button_deleteCourse = new Button();
            button_updateCourses = new Button();
            textBox_inputPoints = new TextBox();
            label_Score = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_enrolledCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_enrolledCourses
            // 
            dataGridView_enrolledCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_enrolledCourses.Columns.AddRange(new DataGridViewColumn[] { 课程编号, 课名, 已投分数 });
            dataGridView_enrolledCourses.Location = new Point(12, 12);
            dataGridView_enrolledCourses.Name = "dataGridView_enrolledCourses";
            dataGridView_enrolledCourses.RowTemplate.Height = 25;
            dataGridView_enrolledCourses.Size = new Size(776, 341);
            dataGridView_enrolledCourses.TabIndex = 0;
            // 
            // 课程编号
            // 
            课程编号.HeaderText = "课程编号";
            课程编号.Name = "课程编号";
            // 
            // 课名
            // 
            课名.HeaderText = "课名";
            课名.Name = "课名";
            // 
            // 已投分数
            // 
            已投分数.HeaderText = "已投分数";
            已投分数.Name = "已投分数";
            // 
            // button_deleteCourse
            // 
            button_deleteCourse.Location = new Point(12, 379);
            button_deleteCourse.Name = "button_deleteCourse";
            button_deleteCourse.Size = new Size(94, 39);
            button_deleteCourse.TabIndex = 1;
            button_deleteCourse.Text = "删除";
            button_deleteCourse.UseVisualStyleBackColor = true;
            button_deleteCourse.Click += button_deleteCourse_Click;
            // 
            // button_updateCourses
            // 
            button_updateCourses.Location = new Point(697, 379);
            button_updateCourses.Name = "button_updateCourses";
            button_updateCourses.Size = new Size(91, 39);
            button_updateCourses.TabIndex = 2;
            button_updateCourses.Text = "更改";
            button_updateCourses.UseVisualStyleBackColor = true;
            button_updateCourses.Click += button_updateCourses_Click;
            // 
            // textBox_inputPoints
            // 
            textBox_inputPoints.Location = new Point(606, 387);
            textBox_inputPoints.Name = "textBox_inputPoints";
            textBox_inputPoints.Size = new Size(76, 23);
            textBox_inputPoints.TabIndex = 4;
            // 
            // label_Score
            // 
            label_Score.AutoSize = true;
            label_Score.Location = new Point(287, 390);
            label_Score.Name = "label_Score";
            label_Score.Size = new Size(43, 17);
            label_Score.TabIndex = 5;
            label_Score.Text = "label1";
            // 
            // 已投分编辑界面
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Score);
            Controls.Add(textBox_inputPoints);
            Controls.Add(button_updateCourses);
            Controls.Add(button_deleteCourse);
            Controls.Add(dataGridView_enrolledCourses);
            Name = "已投分编辑界面";
            Text = "已投分编辑界面";
            Load += 已投分编辑界面_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_enrolledCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_enrolledCourses;
        private Button button_deleteCourse;
        private Button button_updateCourses;
        private TextBox textBox_inputPoints;
        private DataGridViewTextBoxColumn 课程编号;
        private DataGridViewTextBoxColumn 课名;
        private DataGridViewTextBoxColumn 已投分数;
        private Label label_Score;
    }
}