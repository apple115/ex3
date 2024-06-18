using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//Name,ClassName,StartTime,DuringTime,Teacher,Classroom,College
namespace WinFormsApp1
{

    public partial class 选课界面 : Form
    {
        private string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");

        private string loggedInUsername;
        public 选课界面(String Username)
        {
            InitializeComponent();
            loggedInUsername = Username;
            lb欢迎同学.Text = "欢迎 " + Username + " 同学";
        }
        private void 退出登录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // 打开登录界面
            登录界面 loginForm = new 登录界面();
            loginForm.Show();
        }
        private void 选课界面_Load_1(object sender, EventArgs e)
        {
            // 在窗体加载时执行查询操作
            LoadDataToDataGridView();
            // 加载教师列表到 ComboBox
            LoadTeachersToComboBox();
            // 加载学院列表到 ComboBox
            LoadCollegesToComboBox();
            // 显示剩余学分
            DisplayRemainingCredits();
        }
        private void LoadDataToDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Number as 课号, Name as 课名, StartTime as 开始时间, DuringTime as 持续时间, Teacher as 教师, Classroom as 教室, College as 学院, Score as 学分 FROM ClassTable";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        //清空原数据
                        dg课程列表.DataSource = null;
                        dg课程列表.Columns.Clear();
                        // 将结果集绑定到 DataGridView
                        dg课程列表.DataSource = dataTable;
                        dg课程列表.Columns["课号"].DataPropertyName = "课号";
                        dg课程列表.Columns["课名"].DataPropertyName = "课名";
                        dg课程列表.Columns["开始时间"].DataPropertyName = "开始时间";
                        dg课程列表.Columns["持续时间"].DataPropertyName = "持续时间";
                        dg课程列表.Columns["教师"].DataPropertyName = "教师";
                        dg课程列表.Columns["教室"].DataPropertyName = "教室";
                        dg课程列表.Columns["学院"].DataPropertyName = "学院";
                        dg课程列表.Columns["学分"].DataPropertyName = "学分";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }
        private void LoadTeachersToComboBox()
        {
            // 查询数据库，获取教师列表
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT Teacher FROM ClassTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb教师.Items.Add(reader["Teacher"].ToString());
                    }
                }
            }
        }
        private void LoadCollegesToComboBox()
        {
            // 查询数据库，获取学院列表
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT College FROM ClassTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cb学院.Items.Add(reader["College"].ToString());
                    }
                }
            }
        }
        private void cb教师_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 触发教师筛选操作
            FilterDataGridView();
        }
        private void cb学院_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 触发学院筛选操作
            FilterDataGridView();
        }
        private void FilterDataGridView()
        {
            // 构建筛选条件
            string filterExpression = "";
            if (!string.IsNullOrEmpty(cb教师.Text))
            {
                filterExpression += $"教师 = '{cb教师.Text}'";
            }
            if (!string.IsNullOrEmpty(cb学院.Text))
            {
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression += " AND ";
                }
                filterExpression += $"学院 = '{cb学院.Text}'";
            }
            // 应用筛选条件
            ApplyFilter(filterExpression);
        }
        private void ApplyFilter(string filterExpression)
        {
            // 获取数据视图
            DataView dv = ((DataTable)dg课程列表.DataSource).DefaultView;
            // 应用筛选条件
            dv.RowFilter = filterExpression;
        }
        private void DisplayRemainingCredits()
        {
            try
            {
                int userScore = GetUserScore(loggedInUsername);
                lb剩余学分.Text = $"你还剩 {userScore} 学分";
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询学分失败：" + ex.Message);
            }
        }
        private void bt刷新_Click(object sender, EventArgs e)
        {
            // 1. 清空 ComboBox 的选择
            cb教师.SelectedIndex = -1;
            cb学院.SelectedIndex = -1;
            // 2. 重新加载所有课程到 DataGridView
            LoadDataToDataGridView();
            // 3. 清空筛选条件
            // 将 filterExpression 置为空字符串
            string filterExpression = "";
            // 应用筛选条件
            ApplyFilter(filterExpression);
        }
        private void bt选课_Click(object sender, EventArgs e)
        {
            try
            {
                // 获取当前选中的课程信息
                DataRowView selectedRow = (DataRowView)dg课程列表.CurrentRow.DataBoundItem;
                string classNumber = selectedRow["课号"].ToString();
                int courseScore = int.Parse(selectedRow["学分"].ToString());
                // 查询当前用户的学分
                int userScore = GetUserScore(loggedInUsername);
                // 检查学分是否足够
                if (userScore >= courseScore)
                {
                    // 更新 Select_Class 表
                    InsertIntoSelectClass(loggedInUsername, classNumber);
                    // 更新 Student 表中的学分
                    UpdateUserScore(loggedInUsername, userScore - courseScore);
                    MessageBox.Show("选课成功！");
                    // 刷新剩余学分的显示
                    DisplayRemainingCredits();
                }
                else
                {
                    MessageBox.Show("选课失败，学分不足！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("选课失败：" + ex.Message);
            }
        }
        //查询当前用户学分
        private int GetUserScore(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Score FROM Student WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
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
        // 插入一条元组到 Select_Class 表
        private void InsertIntoSelectClass(string studentNumber, string classNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Select_Class (Student_Number, Class_Number) VALUES (@StudentNumber, @ClassNumber)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@ClassNumber", classNumber);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void 选课界面_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dg课程列表_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
    {
        // 获取选中行的课程号
        string 课号 = dg课程列表.Rows[e.RowIndex].Cells["课号"].Value.ToString();
        // 弹出窗口显示该课程的学生
        ShowStudentsForCourse(课号);
    }
        }
        private void ShowStudentsForCourse(string 课号)
        {
            // 创建一个新窗口来显示学生信息
            学生列表 studentWindow = new 学生列表(课号);
            studentWindow.Show();
        }

        
    }
}