using MongoDB.Driver.Core.Configuration;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class 教师界面 : Form
    {
        public string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");

        private string loggedInUsername;
        public 教师界面(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
        }
        private void 教师界面_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            // 打开登录界面
            登录界面 loginForm = new 登录界面();
            loginForm.Show();
        }
        private void 教师界面_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Number as 课号, Name as 课名, StartTime as 开始时间, DuringTime as 持续时间, Teacher as 教师, Classroom as 教室, College as 学院 FROM ClassTable";
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }

        private void dg课程列表_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取选中行的课程号
            string selectedCourseNumber = dg课程列表.Rows[e.RowIndex].Cells["课号"].Value.ToString();
            // 创建学生列表窗口
            学生列表 studentListForm = new 学生列表(selectedCourseNumber);
            // 显示学生列表窗口
            studentListForm.ShowDialog();
        }
        private void bt我教授的课_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loggedInUsername))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // 根据用户名获取教师的教工号（Number）
                        string teacherNumberQuery = $"SELECT Number FROM Teacher WHERE Username = '{loggedInUsername}'";
                        using (SqlCommand teacherNumberCommand = new SqlCommand(teacherNumberQuery, connection))
                        {
                            string teacherNumber = teacherNumberCommand.ExecuteScalar()?.ToString();
                            if (!string.IsNullOrEmpty(teacherNumber))
                            {
                                // 根据教工号获取教师姓名
                                string teacherNameQuery = $"SELECT Name FROM Teacher WHERE Number = '{teacherNumber}'";
                                using (SqlCommand teacherNameCommand = new SqlCommand(teacherNameQuery, connection))
                                {
                                    string teacherName = teacherNameCommand.ExecuteScalar()?.ToString();

                                    if (!string.IsNullOrEmpty(teacherName))
                                    {
                                        // 根据教师姓名获取教师所教授的课程
                                        string teacherCoursesQuery = $"SELECT Number as 课号, Name as 课名, StartTime as 开始时间, DuringTime as 持续时间, Classroom as 教室, College as 学院, Day as 星期, Time as 节次 FROM ClassTable" +
                                                                    $"FROM ClassTable WHERE Teacher = '{teacherName}'";
                                        using (SqlCommand command = new SqlCommand(teacherCoursesQuery, connection))
                                        {
                                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                                            DataTable dataTable = new DataTable();
                                            adapter.Fill(dataTable);
                                            // 清空原数据
                                            dg课程列表.DataSource = null;
                                            dg课程列表.Columns.Clear();
                                            // 将结果集绑定到 DataGridView
                                            dg课程列表.DataSource = dataTable;
                                            dg课程列表.Columns["课号"].DataPropertyName = "课号";
                                            dg课程列表.Columns["课名"].DataPropertyName = "课名";
                                            dg课程列表.Columns["开始时间"].DataPropertyName = "开始时间";
                                            dg课程列表.Columns["持续时间"].DataPropertyName = "持续时间";
                                            dg课程列表.Columns["教室"].DataPropertyName = "教室";
                                            dg课程列表.Columns["学院"].DataPropertyName = "学院";
                                            dg课程列表.Columns["星期"].DataPropertyName = "星期";//24日新增1
                                            dg课程列表.Columns["节次"].DataPropertyName = "节次";//24日新增2
                                        }
                                    }
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
        }
        private void bt刷新_Click(object sender, EventArgs e)
        {
            LoadAllCoursesToDataGridView();
        }
        private void LoadAllCoursesToDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Number as 课号, Name as 课名, StartTime as 开始时间, DuringTime as 持续时间, Teacher as 教师, Classroom as 教室, College as 学院 FROM ClassTable";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // 清空原数据
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }
    }
} 