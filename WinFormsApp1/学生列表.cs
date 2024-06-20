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

namespace WinFormsApp1
{
    public partial class 学生列表 : Form
    {
        public string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING");
        private string selectedCourseNumber;
        public 学生列表(string 课号)
        {
            InitializeComponent();
            selectedCourseNumber = 课号;
            lb课号.Text = selectedCourseNumber;
        }
        private void 学生列表_Load(object sender, EventArgs e)
        {
            LoadStudentsToDataGridView();
        }
        private void LoadStudentsToDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT s.Number as 学号, s.Name as 姓名, s.Profession as 专业, s.ClassNumber as 班级 " +
                                   $"FROM Student s " +
                                   $"JOIN Select_Class sc ON s.Number = sc.Student_Number " +
                                   $"WHERE sc.Class_Number = '{selectedCourseNumber}'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            //清空原数据
                            dg学生列表.DataSource = null;
                            dg学生列表.Columns.Clear();
                            // 将结果集绑定到 DataGridView
                            dg学生列表.DataSource = dataTable;
                            dg学生列表.Columns["学号"].DataPropertyName = "学号";
                            dg学生列表.Columns["姓名"].DataPropertyName = "姓名";
                            dg学生列表.Columns["专业"].DataPropertyName = "专业";
                            dg学生列表.Columns["班级"].DataPropertyName = "班级";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }
        private void 学生列表_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
        private void bt添加学生_Click(object sender, EventArgs e)
        {
            // 创建添加学生窗口时传递课程号
            添加学生 添加学生 = new 添加学生(selectedCourseNumber);
            // 显示添加学生窗口
            DialogResult result = 添加学生.ShowDialog();
            // 如果用户确认添加学生，则刷新学生列表
            if (result == DialogResult.OK)
            {
                LoadStudentDataToDataGridView(selectedCourseNumber);
            }
        }
        private void LoadStudentDataToDataGridView(string selectedCourseNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT s.Number as 学号, s.Name as 姓名, s.Profession as 专业, s.ClassNumber as 班级 " +
                                    $"FROM Student s " +
                                    $"JOIN Select_Class sc ON s.Number = sc.Student_Number " +
                                    $"WHERE sc.Class_Number = '{selectedCourseNumber}'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // 清空原数据
                        dg学生列表.DataSource = null;
                        dg学生列表.Columns.Clear();
                        // 将结果集绑定到 DataGridView
                        dg学生列表.DataSource = dataTable;
                        dg学生列表.Columns["学号"].DataPropertyName = "学号";
                        dg学生列表.Columns["姓名"].DataPropertyName = "姓名";
                        dg学生列表.Columns["专业"].DataPropertyName = "专业";
                        dg学生列表.Columns["班级"].DataPropertyName = "班级";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }
        private void bt删除学生_Click(object sender, EventArgs e)
        {
            // 确保选中了至少一行
            if (dg学生列表.SelectedRows.Count > 0)
            {
                // 获取选中行的学号
                string studentNumber = dg学生列表.SelectedRows[0].Cells["学号"].Value.ToString();
                // 提示用户是否确认删除
                DialogResult result = MessageBox.Show("确定要删除学生吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // 如果用户确认删除
                if (result == DialogResult.Yes)
                {
                    // 在这里执行删除选课表中对应元组的 SQL 操作
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            // 在 Select_Class 表中删除对应学生的选课信息
                            string deleteSelectClassQuery = $"DELETE FROM Select_Class WHERE Student_Number = '{studentNumber}'";
                            using (SqlCommand command = new SqlCommand(deleteSelectClassQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("学生删除成功。");
                            // 刷新学生列表
                            LoadStudentDataToDataGridView(selectedCourseNumber);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("发生错误：" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的学生。");
            }
        }
        private void DeleteStudentFromSelectClass(string studentNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // 在 Select_Class 表中删除学生
                    string deleteSelectClassQuery = $"DELETE FROM Select_Class WHERE Student_Number = '{studentNumber}'";
                    using (SqlCommand command = new SqlCommand(deleteSelectClassQuery, connection))
                    {
                        // 执行删除
                        int rowsAffected = command.ExecuteNonQuery();
                        // 检查是否删除成功
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("学生删除成功。");
                            // 刷新学生列表
                            LoadStudentsToDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("未找到学生或学生删除失败。");
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
}