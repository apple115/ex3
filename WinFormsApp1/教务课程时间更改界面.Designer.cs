namespace WinFormsApp1
{
    partial class 教务课程时间更改界面
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
            dataGridView_courseTimeChange = new DataGridView();
            学生id = new DataGridViewTextBoxColumn();
            姓名 = new DataGridViewTextBoxColumn();
            课程id = new DataGridViewTextBoxColumn();
            课程名 = new DataGridViewTextBoxColumn();
            教室 = new DataGridViewTextBoxColumn();
            周 = new DataGridViewTextBoxColumn();
            星期 = new DataGridViewTextBoxColumn();
            课次 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            comboBox_周次 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBox_Day = new TextBox();
            textBox_Time = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_courseTimeChange).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_courseTimeChange
            // 
            dataGridView_courseTimeChange.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_courseTimeChange.Columns.AddRange(new DataGridViewColumn[] { 学生id, 姓名, 课程id, 课程名, 教室, 周, 星期, 课次 });
            dataGridView_courseTimeChange.Location = new Point(12, 95);
            dataGridView_courseTimeChange.Name = "dataGridView_courseTimeChange";
            dataGridView_courseTimeChange.RowTemplate.Height = 25;
            dataGridView_courseTimeChange.Size = new Size(776, 279);
            dataGridView_courseTimeChange.TabIndex = 0;
            // 
            // 学生id
            // 
            学生id.HeaderText = "学生id";
            学生id.Name = "学生id";
            // 
            // 姓名
            // 
            姓名.HeaderText = "姓名";
            姓名.Name = "姓名";
            // 
            // 课程id
            // 
            课程id.HeaderText = "课程id";
            课程id.Name = "课程id";
            // 
            // 课程名
            // 
            课程名.HeaderText = "课程名";
            课程名.Name = "课程名";
            // 
            // 教室
            // 
            教室.HeaderText = "教室";
            教室.Name = "教室";
            // 
            // 周
            // 
            周.HeaderText = "周";
            周.Name = "周";
            // 
            // 星期
            // 
            星期.HeaderText = "星期";
            星期.Name = "星期";
            // 
            // 课次
            // 
            课次.HeaderText = "课次";
            课次.Name = "课次";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 39);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 3;
            label2.Text = "周次";
            // 
            // comboBox_周次
            // 
            comboBox_周次.FormattingEnabled = true;
            comboBox_周次.Location = new Point(294, 37);
            comboBox_周次.Name = "comboBox_周次";
            comboBox_周次.Size = new Size(121, 25);
            comboBox_周次.TabIndex = 4;
            comboBox_周次.SelectedIndexChanged += comboBox_周次_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 401);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 6;
            label3.Text = "星期";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 401);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 7;
            label4.Text = "课次";
            // 
            // textBox_Day
            // 
            textBox_Day.Location = new Point(194, 401);
            textBox_Day.Name = "textBox_Day";
            textBox_Day.Size = new Size(100, 23);
            textBox_Day.TabIndex = 9;
            // 
            // textBox_Time
            // 
            textBox_Time.Location = new Point(338, 401);
            textBox_Time.Name = "textBox_Time";
            textBox_Time.Size = new Size(100, 23);
            textBox_Time.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(527, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "更改";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // 教务课程时间更改界面
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox_Time);
            Controls.Add(textBox_Day);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox_周次);
            Controls.Add(label2);
            Controls.Add(dataGridView_courseTimeChange);
            Name = "教务课程时间更改界面";
            Text = "教务课程时间更改界面";
            Load += 教务课程时间更改界面_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_courseTimeChange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_courseTimeChange;
        private Label label2;
        private ComboBox comboBox_周次;
        private Label label3;
        private Label label4;
        private TextBox textBox_Day;
        private TextBox textBox_Time;
        private Button button1;
        private DataGridViewTextBoxColumn 学生id;
        private DataGridViewTextBoxColumn 姓名;
        private DataGridViewTextBoxColumn 课程id;
        private DataGridViewTextBoxColumn 课程名;
        private DataGridViewTextBoxColumn 教室;
        private DataGridViewTextBoxColumn 周;
        private DataGridViewTextBoxColumn 星期;
        private DataGridViewTextBoxColumn 课次;
    }
}