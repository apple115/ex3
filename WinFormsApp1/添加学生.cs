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
    public partial class 添加学生 : Form
    {
        private string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");
        private string selectedCourseNumber;
        public 添加学生(string selectedCourseNumber)
        {
            InitializeComponent();
            this.selectedCourseNumber = selectedCourseNumber;
            Load专业列表(); // 在窗口加载时加载专业列表
        }
        private void Load专业列表()
        {
            // 从数据库中获取专业列表
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT Profession FROM Student";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (reader.Read())
                            {
                                cb专业.Items.Add(reader["Profession"].ToString());
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
        private void bt添加学生_Click(object sender, EventArgs e)
        {
            // 获取学生信息
            string 学号 = tb学号.Text;
            string 姓名 = tb姓名.Text;
            string 专业 = cb专业.SelectedItem?.ToString(); // 获取选择的专业
            string 班级 = tb班级.Text;
            this.DialogResult = DialogResult.OK;
            // 执行添加学生操作
            AddStudent(学号, 姓名, 专业, 班级, selectedCourseNumber);
        }
        private void AddStudent(string studentNumber, string studentName, string profession, string classNumber, string selectedCourseNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 在此处查询选课表，确保选课表中不存在相同学号的学生
                    string selectQuery = $"SELECT * FROM Select_Class WHERE Student_Number = '{studentNumber}' AND Class_Number = '{selectedCourseNumber}'";
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            // 如果查询结果为空，表示选课表中不存在相同学号的学生，可以执行插入操作
                            if (!reader.HasRows)
                            { 
                                // 在此处执行将学生选课信息插入到 Select_Class 表的 SQL 语句
                                string insertSelectClassQuery = $"INSERT INTO Select_Class (Class_Number, Student_Number) " +
                                                                $"VALUES ('{selectedCourseNumber}', '{studentNumber}')";
                                using (SqlCommand command = new SqlCommand(insertSelectClassQuery, connection))
                                {
                                    command.ExecuteNonQuery();
                                }
                                MessageBox.Show("学生添加成功。");
                            }
                            else
                            {
                                MessageBox.Show("选课表中已存在相同学号的学生，无法添加。");
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }
        private void 添加学生_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}