using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using MongoDB.Driver.Core.Configuration;

namespace WinFormsApp1
{
    public partial class 登录界面 : Form
    {
        public string Username;
        public string connectionString = @"Data Source=LAPTOP-DN3TKTF5;Initial Catalog=Class;Integrated Security=True;MultipleActiveResultSets=true";
        public 登录界面()
        {
            InitializeComponent();
        }
        void bt登录_Click(object sender, EventArgs e)
        {
            string username = tb用户名.Text;
            string password = tb密码.Text;
            int userType = ValidateForm(username, password);
            if (userType != 0)
            {
                // 根据用户类型跳转到不同的界面
                switch (userType)
                {
                    case 1:
                        // 登录成功
                        MessageBox.Show("祝你选到理想的课程！");
                        Username = username;
                        this.Hide();
                        // 跳转到界面2
                        选课界面 form2 = new 选课界面(Username); // 替换为实际的界面1类名
                        form2.Show();
                        break;
                    case 2:
                        // 跳转到界面3
                        MessageBox.Show("祝您工作顺利！");
                        Username = username;
                        this.Hide();
                        // 跳转到界面3
                        教师界面 form3 = new 教师界面(Username); // 替换为实际的界面2类名
                        form3.Show();
                        break;
                    case 3:
                        // 跳转到界面4
                        MessageBox.Show("可以进行修改了！");
                        Username = username;
                        this.Hide();
                        教务界面 form4 = new 教务界面(Username); // 替换为实际的界面2类名
                        form4.Show();
                        break;
                    default:
                        MessageBox.Show("未知用户类型！");
                        break;

                }
            }
            else
            {
                // 登录失败
                MessageBox.Show("用户名或密码错误！");
            }
        }
        int ValidateForm(string username, string password)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();//
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT Categories FROM Users WHERE Username=@Username AND Password=@Password";
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    var result = command.ExecuteScalar();
                    // 如果存在匹配的用户名和密码，返回用户类型，否则返回0表示登录失败
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
                return 0;
            }
        }
        private void 登录界面_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}