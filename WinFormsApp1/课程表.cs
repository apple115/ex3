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
        public int week = 1;


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
            week = int.Parse(cb课程表.Text.ToString().TrimStart(' ').Trim().TakeWhile(char.IsDigit).ToArray());
            LoadListView(week);
        }

        private void LoadToDataGridView(string username, string week)
        {
            DataTable courseData = Tools.Instance.GetCourseDataByUserid(username);

        }
        private void 课程表_Load(object sender, EventArgs e)
        {
            LoadCourseWeeksToComboBox();
            LoadListView(week);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadListViewItem(ListViewItem item, string Day, DataTable courseData,int week)
        {
            for(int i = 0; i < 5; i++)
            {
                item.SubItems.Add(" ");
            }
            foreach (DataRow dataRow in courseData.Rows)
            {
                if ((string)dataRow["Day"] == Day && int.Parse((string)dataRow["StartWeek"])<=week &&  week <= int.Parse((string)dataRow["FinWeek"]))
                {
                    item.SubItems[int.Parse((string)dataRow["Time"])].Text = $"{(string)dataRow["Name"]} {(string)dataRow["Classroom"]}";
                }
            }
        }
        private void LoadListView(int week)
        {
            DataTable courseData = Tools.Instance.GetCourseDataByUserid(username);
            // 第一节课
            listView1.Items.Clear();
            listView1.LabelWrap = true;
            ListViewItem item1 = new ListViewItem("星期一");
            ListViewItem item2 = new ListViewItem("星期二");
            ListViewItem item3 = new ListViewItem("星期三");
            ListViewItem item4 = new ListViewItem("星期四");
            ListViewItem item5 = new ListViewItem("星期五");
            ListViewItem item6 = new ListViewItem("星期六");
            ListViewItem item7 = new ListViewItem("星期七");

            LoadListViewItem(item1, "1", courseData,week);
            LoadListViewItem(item2, "2", courseData, week);
            LoadListViewItem(item3, "3", courseData, week);
            LoadListViewItem(item4, "4", courseData, week);
            LoadListViewItem(item5, "5", courseData, week);
            LoadListViewItem(item6, "6", courseData, week);
            LoadListViewItem(item7, "7", courseData, week);

            listView1.Items.Add(item1); 
            listView1.Items.Add(item2); 
            listView1.Items.Add(item3); 
            listView1.Items.Add(item4); 
            listView1.Items.Add(item5); 
            listView1.Items.Add(item6); 
            listView1.Items.Add(item7); 
        }
    }
}
