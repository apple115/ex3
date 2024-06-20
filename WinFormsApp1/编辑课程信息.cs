using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class 编辑课程信息 : Form
    {
        // 这个是一个注释 zht 写的1234567890

        private string selectedCourseNumber;
        public delegate void CourseEditedHandler();
        public event CourseEditedHandler OnCourseEdited;
        public string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");
        public 编辑课程信息(string selectedCourseNumber)
        {
            InitializeComponent();
            this.selectedCourseNumber = selectedCourseNumber;

            // 加载选中课程的信息
            LoadSelectedCourseInfo();
        }
        private void LoadSelectedCourseInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 在此处查询选中课程的信息
                    string selectCourseQuery = $"SELECT * FROM ClassTable WHERE Number = '{selectedCourseNumber}'";
                    using (SqlCommand command = new SqlCommand(selectCourseQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 将选中课程的信息显示在文本框
                                tb课名.Text = reader["Name"].ToString();
                                tb开始时间.Text = reader["StartTime"].ToString();
                                tb持续时间.Text = reader["DuringTime"].ToString();
                                tb教师.Text = reader["Teacher"].ToString();
                                tb教室.Text = reader["Classroom"].ToString();
                                tb学院.Text = reader["College"].ToString();
                                tb学分.Text = reader["Score"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }
        private void bt保存_Click(object sender, EventArgs e)
        {
            // 获取用户输入的课程信息
            string courseName = tb课名.Text;
            string startTime = tb开始时间.Text;
            string duringTime = tb持续时间.Text;
            string teacher = tb教师.Text;
            string classroom = tb教室.Text;
            string college = tb学院.Text;
            string score = tb学分.Text;
            // 更新数据库中的课程信息
            UpdateCourseInfo(selectedCourseNumber, courseName, startTime, duringTime, teacher, classroom, college, score);
            // 触发事件，通知父窗口刷新课程列表
            OnCourseEdited?.Invoke();
        }
        private void UpdateCourseInfo(string courseNumber, string courseName, string startTime, string duringTime, string teacher, string classroom, string college, string credit)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // 在此处执行将课程信息更新到 ClassTable 表的 SQL 语句
                    string updateCourseQuery = $"UPDATE ClassTable SET Name = '{courseName}', StartTime = '{startTime}', DuringTime = '{duringTime}', " +
                                                $"Teacher = '{teacher}', Classroom = '{classroom}', College = '{college}', Score = '{credit}' " +
                                                $"WHERE Number = '{courseNumber}'";
                    using (SqlCommand command = new SqlCommand(updateCourseQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("课程信息修改成功。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }
        private void 编辑课程信息_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
