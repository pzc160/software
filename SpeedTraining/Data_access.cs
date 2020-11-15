using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SpeedTraining
{
    class Data_access
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
            connection.Open();
            return connection;
        }//打开数据库连接

        public static SqlDataReader QueryLevelData(int traintype, int levelnum)
        {
            SqlConnection connection = GetConnection();
            string stm = "select * from leveldata where traintype=@traintype and levelnum=@levelnum";
            using (SqlCommand cmd = new SqlCommand(stm, connection))
            {
                cmd.Parameters.AddWithValue("@traintype", traintype);
                cmd.Parameters.AddWithValue("@levelnum", levelnum);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
        }//根据训练类型和关卡等级查询关卡数据

        public static void UpdateHscore(int traintype, int levelnum,int highestscore)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand
                ("update leveldata set highestscore=@highestscore where traintype=@traintype and levelnum=@levelnum", connection))
                {
                    cmd.Parameters.AddWithValue("@traintype", traintype);
                    cmd.Parameters.AddWithValue("@levelnum", levelnum);
                    cmd.Parameters.AddWithValue("@highestscore", highestscore);
                    cmd.ExecuteNonQuery();
                }
            }
        }//修改关卡中的最高分数
    }
}
