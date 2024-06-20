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
    public partial class 添加课程 : Form
    {
        public string connectionString = File.ReadAllText(@"../../../Resource/SQLSTRING.txt");
        public 添加课程()
        {
            InitializeComponent();
        }

        private void bt添加课程_Click(object sender, EventArgs e)
        {
            // 获取新课程信息
            string courseNumber = tb课号.Text;
            string courseName = tb课名.Text;
            string startTime = tb开始时间.Text;
            string duringTime = tb持续时间.Text;
            string teacher = tb教师.Text;
            string classroom = tb教室.Text;
            string college = tb学院.Text;
            string score = tb学分.Text;
            // 检查是否存在相同课号的课程
            if (IsCourseNumberExist(courseNumber))
            {
                MessageBox.Show("相同课号的课程已存在，无法添加。");
                return; // 如果存在相同课号的课程，不执行添加操作
            }
            // 执行添加课程的操作
            AddCourse(courseNumber, courseName, startTime, duringTime, teacher, classroom, college, score);
        }
        private bool IsCourseNumberExist(string courseNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // 查询是否存在相同课号的课程
                    string query = $"SELECT COUNT(*) FROM ClassTable WHERE Number = '{courseNumber}'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
                return false; // 出现异常，默认返回不存在相同课号的课程
            }
        }
        private void AddCourse(string courseNumber, string courseName, string startTime, string duringTime, string teacher, string classroom, string college, string score)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // 执行插入新课程的 SQL 语句
                    string insertQuery = $"INSERT INTO ClassTable (Number, Name, StartTime, DuringTime, Teacher, Classroom, College, Score) " +
                                         $"VALUES ('{courseNumber}', '{courseName}', '{startTime}', '{duringTime}', '{teacher}', '{classroom}', '{college}', '{score}')";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("课程添加成功。");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }
        private void 添加课程_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
