using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLBookAvenue
{
    public class User
    {

        public int userID { get; internal set; }
        public string username { get; set; }
        public string password { get; set; }

        internal User(){}

        

        internal static User getUser(string username, string password)
        {
            SqlConnection conn = Starter.getConnection();
            SqlCommand cmd;
            string sql;

            sql = "select * from Users where username=@username AND password=@password";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("username", username);

            SqlDataReader reader = cmd.ExecuteReader();
            User e = null;
            
            if (reader.Read())
            {
                e = new User();
                e.userID = reader.GetInt32(0);
                e.username = reader.GetString(1);
                e.password = reader.GetString(2);
                

            }

            conn.Close();
            return e;           

        }

        internal static bool login(string username, string password)
        {
            SqlConnection conn = Starter.getConnection();
            SqlCommand cmd;
            string sql;

            sql = "select * from Benutzer where username=@username AND password=@password";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("username", username);

            SqlDataReader reader = cmd.ExecuteReader();
            bool login = false;

            if (reader.Read())
            {
                login = true;
            }
            else
            {
                login = false;
            }
            conn.Close();
            return login;           
        }

        internal static bool checkUsername(string username)
        {
            SqlConnection conn = Starter.getConnection();
            SqlCommand cmd;
            string sql;

            sql = "select * from Users where username=@username";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("username", username);

            SqlDataReader reader = cmd.ExecuteReader();
            bool b;

            if (reader.Read())
            {
                b = true;
            }
            else
            {
                b = false;
            }
            conn.Close();
            return b;
        }

        internal static bool register(string username, string password)
        {
            SqlConnection conn = Starter.getConnection();
            SqlCommand cmd;
            string sql;

            sql = "insert into Users (username, password) values (@username, @password)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("username", username);
            return (cmd.ExecuteNonQuery() > 0);
        }

    }
}
