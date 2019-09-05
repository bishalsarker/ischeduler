using ISchedulerPWA.Models;
using ISchedulerPWA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class EditScheduleP
    {
        
        public string schedule_title;
        public string date, month, year;
        public string hour, minute, time;
        public string location;
        public string priority;
        public string repeat;
        public string sid;
        public string serverResponse;

        public EditScheduleP(){}

        public EditScheduleP(string t, string d, string m, string y, 
        string h, string min, string tm, string l, string p, string r, string uid)
        {
            this.schedule_title = t;
            this.date = d;
            this.month = m;
            this.year = y;
            this.minute = min;
            this.hour = h;
            this.time = tm;
            this.location = l;
            this.priority = p;
            this.repeat = r;
            this.sid = uid;
            editSch();
        }

        private void editSch()
        {
            ScheduleM sm = new ScheduleM();
            sm.schedule_id = this.sid;
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
            sm.updateSch();

            if (sm.response == "500")
            {
                serverResponse = "500";
            }
            else
            {
                serverResponse = "";
            }
        }
        public EditScheduleP getSch(string sid)
        {
            EditScheduleP info = new EditScheduleP();
            ScheduleM sm = new ScheduleM();
            sm.schedule_id = sid;
            sm = sm.getSchedulesById();

            Dt dt = new Dt();

            info.schedule_title = sm.schedule_title;
            info.date = sm.date;
            info.month = sm.month;
            info.year = sm.year;
            info.hour = sm.hour;
            info.minute = sm.minute;
            info.time = sm.time;
            info.location = sm.location;
            info.priority = sm.priority;

            if (sm.response == "500")
            {
                info.serverResponse = "500";
            }

            return info;
        }
    }
}