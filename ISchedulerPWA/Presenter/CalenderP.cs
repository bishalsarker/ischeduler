using ISchedulerPWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class CalenderP
    {
        private string user_id;
        public string date;
        public string month;
        public string year;
        public string serverResponse = "";

        public CalenderP(string id, string d, string m, string y)
        {
            this.user_id = id;
            this.date = d;
            this.month = m;
            this.year = y;
        }
        public string getUserFullname()
        {
            UserM um = new UserM();
            um.user_id = this.user_id;
            um = um.getUserByUserId();
            if (um.response == "500")
            {
                serverResponse = "500";
                return "";
            }
            else
            {
                return um.fullname;
            }
        }
        public string getEventList()
        {
            string list = "";
            ScheduleM sm = new ScheduleM();
            sm.date = this.date;
            sm.month = this.month;
            sm.year = this.year;
            sm.user_id = this.user_id;

            string priority = "";

            foreach (ScheduleM sch in sm.getSchedulesByDate())
            {
                if (sch.priority == "1")
                {
                    priority = "<span class='red-dot'>O</span> High";
                }
                if (sch.priority == "2")
                {
                    priority = "<span class='green-dot'>O</span> Medium";
                }
                if (sch.priority == "3")
                {
                    priority = "<span class='green-dot'>O</span> Low";
                }

                list = list + "<div class='event-box'>"+
                              "<a href='/view/schedule?sid=" + sch.schedule_id + "'>" +
					          "<div class='event-box-time'>" + sch.hour + ": " + sch.minute + sch.time + "</div>"+
					          "<div class='event-box-title'>"+ sch.schedule_title + "</div>"+
					          "<div class='event-box-priority'>"+ priority +"</div>"+
				              "</a></div>";
            }

            if (sm.response == "500")
            {
                serverResponse = "500";
            }

            if (list == "")
            {
                return "No schedules have been added yet!";
            }
            else{
                return list;
            }
        }
        public string getEventCards()
        {
            string list = "";
            Random rnd = new Random();
            ScheduleM sm = new ScheduleM();
            sm.month = this.month;
            sm.year = this.year;
            sm.user_id = this.user_id;

            foreach (string date in sm.getAllDates())
            {
                int cardColor = rnd.Next(1, 4);
                string card = "<div class='date-card-small date-card-small-" + cardColor.ToString() + "'>" +
                              "<a href='calender?y=2018&m=4&d=" + date + "'><div class='date-card-small-date'>" + date + "</div><ul class='card-list'>";

                string schList = "";
                List<string> schedules = new List<string>();
                sm.date = date;
                foreach (ScheduleM sch in sm.getSchedulesByDate())
                {
                    schedules.Add(sch.schedule_title);
                }

                if (schedules.Count() < 3)
                {
                    foreach(string schedule in schedules)
                    {
                        schList = schList + "<li>" + schedule + "</li>";
                    }
                }
                else
                {
                    int i = 0;
                    while (i < 3)
                    {
                        schList = schList + "<li>" + schedules[i] + "</li>";
                        i++;
                    }
                    schList = schList + "<li class='center'>...</li>";
                }

                card = card + schList + "</ul></a></div>";
                list = list + card;
            }

            if (sm.response == "500")
            {
                serverResponse = "500";
            }

            if (list == "")
            {
                return "No schedules have been added in this month yet!";
            }
            else
            {
                return list;
            }
        }
    }
}