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
    public partial class 教务学生列表 : Form
    {
        public string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");
        private string selectedCourseNumber;
        public 教务学生列表(string 课号)
        {
            InitializeComponent();
            selectedCourseNumber = 课号;
            lb课号.Text = selectedCourseNumber;
        }

        private void 教务学生列表_Load(object sender, EventArgs e)
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
        private void 教务学生列表_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
