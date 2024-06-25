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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsApp1
{
    public partial class 课程表 : Form
    {
        public string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");
        public string username;


        public 课程表(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadCourseWeeksToComboBox()
        {
            // 查询数据库，获取教师列表
            for (int i = 1; i < 24; i++)
            {
                cb课程表.Items.Add($"{i}周次");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadToDataGridView(string username, string week)
        {
            DataTable courseData = Tools.Instance.GetCourseDataByUserid(username);

        }
        private void 课程表_Load(object sender, EventArgs e)
        {
            LoadCourseWeeksToComboBox();
            LoadListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadListView()
        {
            Timeuiop.Text = "姓名";

            ListViewItem item3 = new ListViewItem("王五");
            item3.SubItems.Add("345678901");

            listView1.Items.Add(item3);
        }
    }
}
