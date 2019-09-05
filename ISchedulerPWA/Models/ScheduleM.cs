using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Models
{
    public class ScheduleM
    {
        public string schedule_id;
        public string schedule_title;
        public string date, month, year;
        public string hour, minute, time;
        public string location;
        public string priority;
        public string repeat;
        public string user_id;
        public string response;

        SqlConnection conn;

        public ScheduleM()
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

        public void addSchedule()
        {
            string query = "insert into schedules(schedule_title, date, month, year, hh, mm, tt, location, priority, repeat, user_id) " +
            "values ('" + this.schedule_title + "','" + this.date + "','" + this.month + "','" + this.year + "','" + this.hour + "','" + 
            this.minute + "','" + this.time + "','" + this.location + "','" + this.priority + "','" + this.repeat + "','" + this.user_id + "')";

            if (openConn() == true)
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
        public List<ScheduleM> getSchedulesByDate()
        {
            List<ScheduleM> list = new List<ScheduleM>();
            string query = "select * from schedules where date='" + this.date + "'and month='" + this.month + "'and year='" + this.year + "' and user_id='" + this.user_id + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ScheduleM
                    {
                        schedule_id = reader["schedule_id"] + "",
                        schedule_title = reader["schedule_title"] + "",
                        hour = reader["hh"] + "",
                        minute = reader["mm"] + "",
                        time = reader["tt"] + "",
                        priority = reader["priority"] + ""
                    });
                }
                reader.Close();
                closeConn();
            }
            else
            {
                this.response = "500";
            }
            return list;
        }
        public ScheduleM getSchedulesById()
        {
            ScheduleM list = new ScheduleM();
            string query = "select * from schedules where schedule_id='" + this.schedule_id + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.schedule_title = reader["schedule_title"] + "";
                    list.date = reader["date"] + "";
                    list.month = reader["month"] + "";
                    list.year = reader["year"] + "";
                    list.hour = reader["hh"] + "";
                    list.minute = reader["mm"] + "";
                    list.time = reader["tt"] + "";
                    list.location = reader["location"] + "";
                    list.priority = reader["priority"] + "";
                }
                reader.Close();
                closeConn();
            }
            else
            {
                this.response = "500";
            }
            return list;
        }
        public void updateSch()
        {
            string query = "update schedules " +
            "set schedule_title='" + this.schedule_title + "',date= '" + this.date + "',month= '" + this.month + "',year = '" + this.year + "',hh = '" + this.hour + "',mm = '" +
            this.minute + "',tt = '" + this.time + "', location = '" + this.location + "', priority = '" + this.priority + "', repeat = '" + this.repeat + "' where schedule_id='" + this.schedule_id + "'";

            if (openConn() == true)
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
        public void deleteSch()
        {
            string query = "delete from schedules where schedule_id='" + this.schedule_id + "'";

            if (openConn() == true)
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
        public string getLastInsertedId()
        {
            string query = "select max(schedule_id) from schedules where user_id='" + this.user_id + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                string id = cmd.ExecuteScalar().ToString();
                closeConn();
                this.response = "200";
                return id;
            }
            else
            {
                this.response = "500";
                return "0";
            }
        }
        public List<string> getAllDates()
        {
            List<string> d = new List<string>();
            string query = "select distinct date from schedules where year='" + this.year + "' and month='" + this.month + "' and user_id='" + this.user_id + "'";
            if (openConn() == true)
            {
                List<int> dates = new List<int>();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dates.Add(int.Parse(reader["date"] + ""));
                }

                reader.Close();
                closeConn();

                dates.Sort();

                foreach (int i in dates)
                {
                    d.Add(i.ToString());
                }

                this.response = "200";
                return d;
            }
            else
            {
                this.response = "500";
                return d;
            }
        }

    }
}