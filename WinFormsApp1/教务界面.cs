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
    public partial class 教务界面 : Form
    {
        private string Username;

        public string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");

        public 教务界面(string Username)
        {
            InitializeComponent();
            this.Username = Username;
        }
        private void 教务界面_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Number as 课号, Name as 课名, StartTime as 开始时间, DuringTime as 持续时间, Teacher as 教师, Classroom as 教室, College as 学院, Day as 星期, Time as 节次 FROM ClassTable";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        //清空原数据
                        dg教务课程列表.DataSource = null;
                        dg教务课程列表.Columns.Clear();
                        // 将结果集绑定到 DataGridView
                        dg教务课程列表.DataSource = dataTable;
                        dg教务课程列表.Columns["课号"].DataPropertyName = "课号";
                        dg教务课程列表.Columns["课名"].DataPropertyName = "课名";
                        dg教务课程列表.Columns["开始时间"].DataPropertyName = "开始时间";
                        dg教务课程列表.Columns["持续时间"].DataPropertyName = "持续时间";
                        dg教务课程列表.Columns["教师"].DataPropertyName = "教师";
                        dg教务课程列表.Columns["教室"].DataPropertyName = "教室";
                        dg教务课程列表.Columns["学院"].DataPropertyName = "学院";
                        dg教务课程列表.Columns["星期"].DataPropertyName = "星期";//新增1
                        dg教务课程列表.Columns["节次"].DataPropertyName = "节次";//新增2
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }
        private void 教务界面_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void dg教务课程列表_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取选中行的课程号
            string selectedCourseNumber = dg教务课程列表.Rows[e.RowIndex].Cells["课号"].Value.ToString();
            // 创建教务学生列表窗口
            教务学生列表 studentListForm = new 教务学生列表(selectedCourseNumber);
            // 显示教务学生列表窗口
            studentListForm.ShowDialog();
        }
        private void bt编辑课程_Click(object sender, EventArgs e)
        {
            if (dg教务课程列表.SelectedRows.Count > 0)
            {
                // 获取选中行的课程号
                string selectedCourseNumber = dg教务课程列表.SelectedRows[0].Cells["课号"].Value.ToString();
                // 创建编辑课程信息窗口
                编辑课程信息 editCourseForm = new 编辑课程信息(selectedCourseNumber);
                // 处理编辑完成的事件
                editCourseForm.OnCourseEdited += () => LoadAllCoursesToDataGridView();
                // 显示编辑窗口
                editCourseForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择要编辑的课程。");
            }
        }

        /// <summary>
        /// 1.从ClassTable 中读取 课程id Number  可选数量 Capacity 已选数量 Selected 
        /// 对于每个课程
        ///     从CoursesPoints 按照课程id 按照分数(Point)从大到小 读取可选容量(capacity) 用户(UserId) 课程(Coursesld) 分数(Points),清空这个
        ///         按照这个可选排名
        ///             对于每个人
        ///                 选课信息放入Select_Class
        ///                 删除这个CoursePoints的数据
        ///                 selected 更改
        ///             
        /// 剩下的返换
        /// 清空所有CoursePoint的信息
        /// 返回这个的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_stopSelectCourse_Click(object sender, EventArgs e)
        {
            try
            {
                //1 
                DataTable classTable = Tools.Instance.getClassTableALLNumberCapacityAndSelected();
                foreach (DataRow row in classTable.Rows)
                {
                    string classTable_number = (String)row["Number"];
                    int classTable_capacity = (int)row["Capacity"];
                    int classTable_selected = (int)row["selected"];
                    DataTable CoursePoints = Tools.Instance.getScoreByCoursesIdSortPointsByCourseIdAndCapacity(classTable_number, classTable_capacity - classTable_selected);
                    foreach (DataRow cpRow in CoursePoints.Rows)
                    {
                        Tools.Instance.addSelectClass((string)cpRow["UserId"], classTable_number);
                        Tools.Instance.deleteInCoursesPoinst((string)cpRow["UserID"], classTable_number);
                        classTable_selected++;
                    }
                    //跟该 select 中的数据
                    Tools.Instance.setSelectedInClassTable(classTable_number, classTable_selected);
                }

                DataTable coursePoint = Tools.Instance.getAllCoursePoint();
                foreach (DataRow row in coursePoint.Rows)
                {
                    string userId = (String)row["UserId"];
                    int points = (int)row["Points"];
                    string courseId = (string)row["CoursesId"];
                    int current_points = Tools.Instance.getStudentScore(userId);
                    Tools.Instance.UpdateStudentScore(userId, current_points + points);
                }
                Tools.Instance.deleteAllCouresPoint();
                MessageBox.Show("已经停止选课");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }

        private void LoadAllCoursesToDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Number as 课号, Name as 课名, StartTime as 开始时间, DuringTime as 持续时间, Teacher as 教师, Classroom as 教室, College as 学院, Day as 星期, Time as 节次 FROM ClassTable";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // 清空原数据
                        dg教务课程列表.DataSource = null;
                        dg教务课程列表.Columns.Clear();
                        // 将结果集绑定到 DataGridView
                        dg教务课程列表.DataSource = dataTable;
                        dg教务课程列表.Columns["课号"].DataPropertyName = "课号";
                        dg教务课程列表.Columns["课名"].DataPropertyName = "课名";
                        dg教务课程列表.Columns["开始时间"].DataPropertyName = "开始时间";
                        dg教务课程列表.Columns["持续时间"].DataPropertyName = "持续时间";
                        dg教务课程列表.Columns["教师"].DataPropertyName = "教师";
                        dg教务课程列表.Columns["教室"].DataPropertyName = "教室";
                        dg教务课程列表.Columns["学院"].DataPropertyName = "学院";
                        dg教务课程列表.Columns["星期"].DataPropertyName = "星期";//新增1
                        dg教务课程列表.Columns["节次"].DataPropertyName = "节次";//新增2
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }

        private void bt添加课程_Click(object sender, EventArgs e)
        {
            // 创建添加课程窗口
            添加课程 addCourseForm = new 添加课程();
            // 显示添加课程窗口
            addCourseForm.ShowDialog();
            // 刷新教务课程列表
            LoadAllCoursesToDataGridView();
        }

        private void bt删除课程_Click(object sender, EventArgs e)
        {
            // 确保选中了至少一行
            if (dg教务课程列表.SelectedRows.Count > 0)
            {
                // 获取选中行的课程号
                string selectedCourseNumber = dg教务课程列表.SelectedRows[0].Cells["课号"].Value.ToString();
                // 弹出确认对话框
                DialogResult result = MessageBox.Show($"确认删除课程 {selectedCourseNumber} 吗？", "确认删除", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // 执行删除课程的操作
                    DeleteCourse(selectedCourseNumber);
                    // 刷新教务课程列表
                    LoadAllCoursesToDataGridView();
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的课程。");
            }
        }
        private void DeleteCourse(string courseNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // 执行删除课程的 SQL 语句
                    string deleteQuery = $"DELETE FROM ClassTable WHERE Number = '{courseNumber}'";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("课程删除成功。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message);
            }
        }

        private void dg教务课程列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            // 打开登录界面
            登录界面 loginForm = new 登录界面();
            loginForm.Show();
        }

        private void 快速访问ToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }
        private void 课程时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            教务课程时间更改界面 view = new 教务课程时间更改界面();
            view.Show();
        }
        /// <summary>
        /// 将这个根据这个Select_class和class_Table 添加到这个Courses Points 中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_courseTime_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable courseData = Tools.Instance.getCourseData();
                foreach (DataRow row in courseData.Rows)
                {
                    string studentId = (string)row["Student_Number"];
                    string classId = (string)row["Class_Number"];
                    string startWeek = (string)row["StartWeek"];
                    string finWeek = (string)row["FinWeek"];
                    string day = (string)row["Day"];
                    string time = (string)row["Time"];
                    bool hasAllocation = (bool)row["HasAllocation"];

                    if (!hasAllocation)
                    {
                        for (int i = int.Parse(startWeek); i <= int.Parse(finWeek); i++)
                        {
                            Tools.Instance.addCoursesTime(studentId, classId, i.ToString(), day, time);
                        }
                        Tools.Instance.updateHasAlloctionInSelectClass(studentId, classId);
                    }
                }
                MessageBox.Show("分配成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误:" + ex.Message);
            }
        }
    }

}
