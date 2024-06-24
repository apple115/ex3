using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class 已投分编辑界面 : Form
    {
        public event EventHandler<FormClosedEventArgs> CustomFormClosing;

        private string loggedInUsername;
        public 已投分编辑界面(String Username)
        {
            InitializeComponent();
            loggedInUsername = Username;
        }

        private void 已投分编辑界面_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            DisplayScore();
        }


        /// <summary>
        /// 
        /// </summary>
        private void LoadDataToDataGridView()
        {
            try
            {
                DataTable dataTable = Tools.Instance.getNumberNameAndPointsByuserId(loggedInUsername);
                dataGridView_enrolledCourses.DataSource = dataTable;
                dataGridView_enrolledCourses.Columns["课程编号"].DataPropertyName = "Number";
                dataGridView_enrolledCourses.Columns["课名"].DataPropertyName = "Name";
                dataGridView_enrolledCourses.Columns["已投分数"].DataPropertyName = "Points";
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
        }

        private void DisplayScore()
        {
            try
            {
                int userScore = Tools.Instance.getStudentScore(loggedInUsername);
                label_Score.Text = $"有{userScore}";
            }
            catch (Exception ex){ 
                MessageBox.Show("查询学分失败：" + ex.Message);
            }
        }

        private void button_deleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)dataGridView_enrolledCourses.CurrentRow.DataBoundItem;
                if (selectedRow["Number"] == null)
                {
                    MessageBox.Show("请选择课程");
                    return;
                }

                string classNumber = selectedRow["Number"].ToString();
                int userScore = Tools.Instance.getStudentScore(loggedInUsername);
                int points = (int)selectedRow["Points"];

                Tools.Instance.deleteInCoursesPoinst(classNumber, loggedInUsername);
                //跟新分数
                Tools.Instance.UpdateStudentScore(loggedInUsername, userScore + points);
                //更新
                LoadDataToDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_updateCourses_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)dataGridView_enrolledCourses.CurrentRow.DataBoundItem;
                if (selectedRow["Number"] == null)
                {
                    MessageBox.Show("请选择课程");
                    return;
                }
                int inputScore = 0;
                if(textBox_inputPoints.Text.Length > 0) {
                    inputScore = int.Parse(textBox_inputPoints.Text);
                }
                else
                {
                    MessageBox.Show("未输入分数");
                    return;
                }

                //课程id
                string classNumber = selectedRow["Number"].ToString();
                // 用户分
                int userScore = Tools.Instance.getStudentScore(loggedInUsername);
                //当前分
                int points = (int)selectedRow["Points"];

                if(inputScore > (userScore + points))
                {
                    MessageBox.Show("投分失败,请重新输入。");
                    textBox_inputPoints.Text = "";
                    return;
                }

                //更新这个CoursesPoints
                Tools.Instance.updatePoinstInCoursesPoints(classNumber, loggedInUsername, inputScore);

                //更新这个Student 分数
                Tools.Instance.UpdateStudentScore(loggedInUsername, userScore + points - inputScore);

                MessageBox.Show("更新成功");

                LoadDataToDataGridView();

                DisplayScore();

            }catch(Exception ex)
            {
                MessageBox.Show("投分失败：" + ex.Message);

            }

        }
    }
}
