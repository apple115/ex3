using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    internal class Tools
    {
        private static readonly Tools _instance = new Tools();

        private string connectionString = File.ReadAllText(@"../../../Resources/SQLSTRING.txt");
        // 私有构造函数，防止外部通过new创建实例
        private Tools()
        {

            // 这里可以初始化一些资源
        }

        // 公开的静态属性，用于获取单例实例
        public static Tools Instance
        {
            get
            {
                return _instance;
            }
        }
        /// <summary>
        /// 根据这个username 比如20216978 这种
        /// </summary>
        /// <param name="username"></param>
        /// <returns>这个username的score</returns>
        public int GetUserScore(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Score FROM Student WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public void UpdateUserScore(string username, int newScore)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Student SET Score = @Score WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Score", newScore);
                    command.Parameters.AddWithValue("@Username", username);
                    command.ExecuteNonQuery();
                }
            }
        }



    }
}
