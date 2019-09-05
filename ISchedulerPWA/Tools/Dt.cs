using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Tools
{
    public class Dt
    {
        public string getMonthByVal(int val)
        {
            DateTime dt = new DateTime(2018, val, 1);
            return dt.ToString("MMMM");
        }

        public string getDayNameByVal(string year, string month, string date)
        {
            int d = int.Parse(date);
            int m = int.Parse(month);
            int y = int.Parse(year);
            DateTime dt = new DateTime(y,m,d);
            return dt.ToString("dddd");
        }

        public int getDayVal()
        {
            DateTime dt = DateTime.Now;
            int currentDate = dt.Day;
            return currentDate;
        }

        public int getMonthVal()
        {
            DateTime dt = DateTime.Now;
            int currentMonth = dt.Month;
            return currentMonth;
        }

        public int getYearVal()
        {
            DateTime dt = DateTime.Now;
            int currentYear = dt.Year;
            return currentYear;
        }

        public string getHourVal()
        {
            DateTime dt = DateTime.Now;
            string hh = dt.ToString("hh");
            return hh;
        }

        public string getMinuteVal()
        {
            DateTime dt = DateTime.Now;
            string mm = dt.ToString("mm");
            return mm;
        }

        public string getTimeVal()
        {
            DateTime dt = DateTime.Now;
            string tt = dt.ToString("tt");
            return tt;
        }
    }
}