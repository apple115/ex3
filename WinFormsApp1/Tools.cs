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
        /// 根据这个usernameid比如20216978 得到这个分数
        /// </summary>
        /// <param name="username">学生id</param>
        /// <returns>这个学生的score</returns>
        public int getStudentScore(string username)
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

        /// <summary>
        /// 更新这个usernameid的score
        /// </summary>
        /// <param name="username">学生id</param>
        /// <param name="newScore">新的newScore</param>
        public void UpdateStudentScore(string username, int newScore)
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

        /// <summary>
        /// 向表CoursesPoints 添加数据
        /// </summary>
        /// <param name="userId"> 用户id</param>
        /// <param name="point">用户输入的分数</param>
        /// <param name="courseId">选择的课的id</param>
        public void addCoursesPoints(string userId,int point,string courseId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO CoursesPoints (UserId, Points, CoursesId) VALUES(@UserId, @Points, @CoursesId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Points", point);
                    command.Parameters.AddWithValue("@CoursesId", courseId);

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 在Courses中 通过这个usrId 得到他所有选的课程id(CoursesId)
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataTable getCourseIdByuserIdInCoursesPoints(string userId)
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query = @"SELECT CoursesId FROM CoursesPoints WHERE UserId = @userId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId",userId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 在ClassTable 和 CoursePoints 中得到 Number, Name和Points
        /// </summary>
        /// <param name="userId">userId</param>
        /// <returns>这个课程id(Number)课程(Name)和分数(Point)</returns>
        public DataTable getNumberNameAndPointsByuserId(string userId)
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT Number,Name,Points From ClassTable,CoursesPoints WHERE ClassTable.Number = CoursesPoints.CoursesId and UserId = @userId;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId",userId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }



        /// <summary>
        /// 获取classTable中的所有课号(Number)、容量(Capacity)和已选人数(Selected)
        /// </summary>
        /// <returns>包含课号、容量和已选人数的DataTable</returns>
        public DataTable getClassTableALLNumberCapacityAndSelected()
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query = @"SELECT Number, Capacity, Selected FROM ClassTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }

        public void setSelectedInClassTable(string courseId,int selected)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"Update ClassTable Set Selected=@Selected WHERE  Number = @CourseId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", courseId);
                    command.Parameters.AddWithValue("@Selected", selected);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 从CoursesPoints 按照一个课程id(CoursesId读取读取 用户(UserId) 分数(Points) 按照分数(Point)从大到小 
        /// </summary>
        /// <returns>包含用户(UserId) 分数(Points)的DataTable</returns>
        public DataTable getScoreByCoursesIdSortPointsByCourseIdAndCapacity(string coursesId,int capacity)
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT Top(@Capacity) UserId, Points
            FROM CoursesPoints
            WHERE CoursesId = @CoursesId
            ORDER BY Points DESC;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 添加参数以避免SQL注入
                    command.Parameters.AddWithValue("@CoursesId",coursesId);
                    command.Parameters.AddWithValue("@Capacity",capacity);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 删除这个CoursePoint元素 
        /// </summary>
        /// <param name="courseId">输入课程id</param>
        /// <param name="username">输入用户id</param>
        public void deleteInCoursesPoinst(string courseId,string username)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"Delete From CoursesPoints WHERE CoursesId =@courseId and UserId = @userName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@courseId", courseId);
                    command.Parameters.AddWithValue("@userName", username);
                    command.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// 删除这个CoursePoint 全部
        /// </summary>
        public void deleteAllCouresPoint()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"DELETE FROM CoursesPoints";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// 更新这个用户id 和 课程id 的 选分
        /// </summary>
        /// <param name="courseId"> 输入课程id</param>
        /// <param name="username"> 输入用户id</param>
        public void updatePoinstInCoursesPoints(string courseId,string username,int updatePoints)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"Update CoursesPoints SET Points=@updatePoints WHERE CoursesId =@courseId and UserId = @userName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@updatePoints", updatePoints);
                    command.Parameters.AddWithValue("@courseId", courseId);
                    command.Parameters.AddWithValue("@userName", username);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 向SelectClass 添加信息
        /// </summary>
        /// <param name="userid">学生id</param>
        /// <param name="courseid">课程id</param>
        public void addSelectClass(string userid,string courseid) {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            INSERT INTO Select_Class (Student_Number, Class_Number)
            VALUES (@StudentId, @CourseId);
        ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", userid);
                    command.Parameters.AddWithValue("@CourseId", courseid);
                    command.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns>返回Name,Classroom,StartWeek, FinWeek,Day,Time</returns>
        public DataTable GetCourseDataByUserid(string userid)
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query = @"Select  Name,Classroom,StartWeek, FinWeek,Day,Time From ClassTable,Select_Class WHERE Class_Number = Number AND Student_Number = @stuNumber";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        command.Parameters.AddWithValue("@stuNumber", userid);
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }

    }
}
