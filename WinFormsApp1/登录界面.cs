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
    public partial class ��¼���� : Form
    {
        public string Username;
        public string connectionString = @"Data Source=LAPTOP-DN3TKTF5;Initial Catalog=Class;Integrated Security=True;MultipleActiveResultSets=true";
        public ��¼����()
        {
            InitializeComponent();
        }
        void bt��¼_Click(object sender, EventArgs e)
        {
            string username = tb�û���.Text;
            string password = tb����.Text;
            int userType = ValidateForm(username, password);
            if (userType != 0)
            {
                // �����û�������ת����ͬ�Ľ���
                switch (userType)
                {
                    case 1:
                        // ��¼�ɹ�
                        MessageBox.Show("ף��ѡ������Ŀγ̣�");
                        Username = username;
                        this.Hide();
                        // ��ת������2
                        ѡ�ν��� form2 = new ѡ�ν���(Username); // �滻Ϊʵ�ʵĽ���1����
                        form2.Show();
                        break;
                    case 2:
                        // ��ת������3
                        MessageBox.Show("ף������˳����");
                        Username = username;
                        this.Hide();
                        // ��ת������3
                        ��ʦ���� form3 = new ��ʦ����(Username); // �滻Ϊʵ�ʵĽ���2����
                        form3.Show();
                        break;
                    case 3:
                        // ��ת������4
                        MessageBox.Show("���Խ����޸��ˣ�");
                        Username = username;
                        this.Hide();
                        ������� form4 = new �������(Username); // �滻Ϊʵ�ʵĽ���2����
                        form4.Show();
                        break;
                    default:
                        MessageBox.Show("δ֪�û����ͣ�");
                        break;

                }
            }
            else
            {
                // ��¼ʧ��
                MessageBox.Show("�û������������");
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
                    // �������ƥ����û��������룬�����û����ͣ����򷵻�0��ʾ��¼ʧ��
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("���ݿ����Ӵ���" + ex.Message);
                return 0;
            }
        }
        private void ��¼����_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}