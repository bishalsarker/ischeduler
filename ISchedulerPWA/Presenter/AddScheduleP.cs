using ISchedulerPWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class AddScheduleP
    {
        string schedule_title;
        string date, month, year;
        string hour, minute, time;
        string location;
        string priority;
        string repeat;
        string user_id;
        public string serverResponse;

        public AddScheduleP() { }

        public AddScheduleP(string t, string d, string m, string y, 
        string h, string min, string tm, string l, string p, string r, string uid)
        {
            if (t == "")
            {
                this.schedule_title = "My event";
            }
            else
            {
                this.schedule_title = t;
            }
            
            this.date = d;
            this.month = m;
            this.year = y;
            this.minute = min;
            this.hour = h;
            this.time = tm;
            this.location = l;
            this.priority = p;
            this.repeat = r;
            this.user_id = uid;
            addSch();
        }

        private void addSch()
        {
            ScheduleM sm = new ScheduleM();
            sm.schedule_title = this.schedule_title;
            sm.date = this.date;
            sm.month = this.month;
            sm.year = this.year;
            sm.hour = this.hour;
            sm.minute = this.minute;
            sm.time = this.time;
            sm.location = this.location;
            sm.priority = this.priority;
            sm.repeat = this.repeat;
            sm.user_id = this.user_id;
            sm.addSchedule();

            if (sm.response == "500")
            {
                serverResponse = "500";
            }
            else
            {
                serverResponse = "";
            }
        }
        public string recentEntryID(string uid)
        {
            ScheduleM sm = new ScheduleM();
            sm.user_id = uid;
            return sm.getLastInsertedId();
        }
    }
}