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
    public partial class CourseRecommendationform : Form
    {
        private string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");

        /// <summary>
        /// 登录时用户名
        /// </summary>
        private string loggedInUsername;

        /// <summary>
        /// userName 是传输的过来的当前用户名
        /// </summary>
        /// <param name="userName"></param>
        public CourseRecommendationform(string userName)
        {
            InitializeComponent();
            this.loggedInUsername = userName;
            label1.Text = "推荐选课系统";
        }

        /// <summary>
        /// 1.选择当前的课程信息
        /// 2.查看当前用户的学分
        /// 3.获得当前得用户输入的得分
        /// 4.如果当前用户输入学分小于用户
        /// 5.在数据库中记录当前的学生用户id+分数id+课程id
        /// 在这个中 -1 表示没有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void courseSelect_Click(object sender, EventArgs e)
        {
            try
            {
                // 获取当前选中的课程信息
                DataRowView selectedRow = (DataRowView)dataGridView_courseRecommend.CurrentRow.DataBoundItem;
                string classNumber = selectedRow["课号"]?.ToString()??"-1";

                // 查询当前用户的学分
                int userScore = Tools.Instance.getStudentScore(loggedInUsername);

                // 输入的的分数
                int inputScore = 0;
                if (textBox_inputScore.Text.Length > 0)
                {
                    inputScore = int.Parse(textBox_inputScore.Text);
                }

                if(userScore <inputScore)
                {
                    MessageBox.Show("投分失败,请重新输入。");
                    textBox_inputScore.Text = "";
                    return;
                }
                // 在数据库中记录当前的学生用户id+分数id+课程id
                Tools.Instance.addCoursesPoints(loggedInUsername,inputScore,classNumber);

            }
            catch (FormatException)
            {
                // 处理格式错误的情况，例如显示错误消息
                MessageBox.Show("请输入一个有效的整数。");
                textBox_inputScore.Text = "";
            }
            catch (OverflowException)
            {
                // 处理数值溢出的情况
                MessageBox.Show("数值太大或太小，请输入一个在整数范围内的值。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("投分失败");
            }
        }

        /// <summary>
        ///  加载这个学生数据数据在dataGridView_courseRecommendation
        /// </summary>
        private void LoadDataToDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT  Number as 课号, Name as 课名, StartTime as 开始时间, DuringTime as 持续时间, Teacher as 教师, Classroom as 教室, College as 学院, Capacity as 最多人数,Selected as 已选人数
                        FROM ClassTable ct
                        WHERE EXISTS (
                            SELECT 1 FROM Student s
                            WHERE s.Username = 20215024 AND ct.Score < s.Score
                        )
                        ORDER BY ct.Score ASC;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_courseRecommend.DataSource = null;

                        dataGridView_courseRecommend.Columns.Clear();
                        dataGridView_courseRecommend.DataSource = dataTable;

                        dataGridView_courseRecommend.Columns["课号"].DataPropertyName = "课号";
                        dataGridView_courseRecommend.Columns["课名"].DataPropertyName = "课名";
                        dataGridView_courseRecommend.Columns["开始时间"].DataPropertyName = "开始时间";
                        dataGridView_courseRecommend.Columns["持续时间"].DataPropertyName = "持续时间";
                        dataGridView_courseRecommend.Columns["教师"].DataPropertyName = "教师";
                        dataGridView_courseRecommend.Columns["教室"].DataPropertyName = "教室";
                        dataGridView_courseRecommend.Columns["学院"].DataPropertyName = "学院";
                        dataGridView_courseRecommend.Columns["人数"].DataPropertyName = "最多人数";             
                        dataGridView_courseRecommend.Columns["已选人数"].DataPropertyName = "已选人数";             
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);

            }
        }


        private void CourseRecommendationform_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        /// <summary>
        /// 按钮刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_refresh_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        // 更新 Student 表中的学分
        private void UpdateUserScore(string username, int newScore)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Student SET Score = @Score WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Score", newScore);
                    command.Parameters.AddWithValue("@Username", username);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
