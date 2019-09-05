using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ISchedulerPWA.Models
{
    public class UserM
    {
        public string user_id;
        public string fullname;
        public string username;
        public string email;
        public string password;
        public string response;

        SqlConnection conn;

        public UserM()
        {
            DBConfig db = new DBConfig();
            conn = new SqlConnection(db.getConnStr());
        }
        private bool openConn()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch(SqlException ex)
            {
                return false;
            }
        }
        private bool closeConn()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public void addUser()
        {
            string query = "insert into users(username, fullname, email, password) values ('" + this.username + "','" + this.fullname + "','" + this.email + "','" + this.password + "')";
            if(openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                closeConn();
                this.response = "200";
            }
            else
            {
                this.response = "500";
            }
        }
        public UserM getUserByUsername()
        {
            UserM user = new UserM();
            string query = "select * from users where username='" + this.username + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.user_id = reader["user_id"] + "";
                    user.fullname = reader["fullname"] + "";
                    user.email = reader["email"] + "";
                    user.password = reader["password"] + "";
                    user.response = "200";
                }
                reader.Close();
                closeConn();
                return user;
            }
            else
            {
                user.response = "500";
                return user;
            }
        }
        public UserM getUserByUserId()
        {
            UserM user = new UserM();
            string query = "select * from users where user_id='" + this.user_id + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.username = reader["username"] + "";
                    user.fullname = reader["fullname"] + "";
                    user.email = reader["email"] + "";
                    user.password = reader["password"] + "";
                    user.response = "200";
                }
                reader.Close();
                closeConn();
                return user;
            }
            else
            {
                user.response = "500";
                return user;
            }
        }
        public bool checkIfUsernameExits()
        {
            string query = "select count(*) from users where username='" + this.username + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = int.Parse(cmd.ExecuteScalar() + "");
                closeConn();
                this.response = "200";
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                this.response = "500";
                return false;
            }
        }
        public bool checkIfUserExists()
        {
            string query = "select count(*) from users where username='" + this.username + "' and password='" + this.password + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = int.Parse(cmd.ExecuteScalar() + "");
                closeConn();
                this.response = "200";
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                this.response = "500";
                return false;
            }
        }
    }
}