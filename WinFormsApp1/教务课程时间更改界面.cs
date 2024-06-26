using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class 教务课程时间更改界面 : Form
    {

        private string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");
        public int week = 1;
        public 教务课程时间更改界面()
        {
            InitializeComponent();
        }
        private void LoadCourseWeeksToComboBox()
        {
            // 查询数据库，获取教师列表
            for (int i = 1; i < 24; i++)
            {
                comboBox_周次.Items.Add($"{i}周次");
            }
        }

        private void 教务课程时间更改界面_Load(object sender, EventArgs e)
        {
            LoadCourseWeeksToComboBox();
            LoadCouresDataToListView();

        }

        private void comboBox_周次_SelectedIndexChanged(object sender, EventArgs e)
        {

            week = int.Parse(comboBox_周次.Text.ToString().TrimStart(' ').Trim().TakeWhile(char.IsDigit).ToArray());
            string filter = $"周 = {week}";
            ApplyFilter(filter);
        }

        private void LoadCouresDataToListView()
        {

            try
            {
                string query = @"Select StuId as 学生id,s.Name as 姓名,cls.Number as 课程id,cls.Name as 课程名,Classroom as 教室,ct.Week as 周,ct.Day as 星期,ct.Time as 课次 From ClassTable cls,CoursesTime ct,Student s WHERE ct.ClassNumber = cls.Number and s.Number=ct.StuId";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        //清空原数据
                        dataGridView_courseTimeChange.DataSource = null;
                        dataGridView_courseTimeChange.Columns.Clear();

                        // 将结果集绑定到 DataGridView
                        dataGridView_courseTimeChange.DataSource = dataTable;
                        dataGridView_courseTimeChange.Columns["学生id"].DataPropertyName = "学生id";
                        dataGridView_courseTimeChange.Columns["姓名"].DataPropertyName = "姓名";
                        dataGridView_courseTimeChange.Columns["课程id"].DataPropertyName = "课程id";
                        dataGridView_courseTimeChange.Columns["课程名"].DataPropertyName = "课程名";
                        dataGridView_courseTimeChange.Columns["教室"].DataPropertyName = "教室";
                        dataGridView_courseTimeChange.Columns["周"].DataPropertyName = "周";
                        dataGridView_courseTimeChange.Columns["星期"].DataPropertyName = "星期";
                        dataGridView_courseTimeChange.Columns["课次"].DataPropertyName = "课次";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }
        private void ApplyFilter(string filter)
        {
            DataView dv = ((DataTable)dataGridView_courseTimeChange.DataSource).DefaultView;
            dv.RowFilter = filter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)dataGridView_courseTimeChange.CurrentRow.DataBoundItem;
                if(selectedRow == null) {
                    MessageBox.Show("没有选中");
                    return;
                }
                string studentId = (string)selectedRow["学生id"];
                string classId = (string)selectedRow["课程id"];
                string week = (string)selectedRow["周"];
                string day = (string)selectedRow["星期"];
                string time = (string)selectedRow["课次"];
                if(textBox_Day.Text!=null )
                {
                    day = (string)textBox_Day.Text;
                }
                if(textBox_Time.Text!=null)
                {
                    time = (string)textBox_Time.Text;
                }

                //根据这个学生id，课程id，周次确定 一个 更改day和time
                Tools.Instance.updateCouresTime(studentId, classId, week, day, time);
                MessageBox.Show("更改成功");
                LoadCouresDataToListView();
                textBox_Day.Text = string.Empty;
                textBox_Time.Text = string.Empty;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
