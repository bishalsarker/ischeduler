using ISchedulerPWA.Presenter;
using ISchedulerPWA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISchedulerPWA.Views
{
    public partial class Calender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                string userid = Session["user"].ToString();
                int month = int.Parse(Request.QueryString["m"]);
                string year = Request.QueryString["y"];
                string date = Request.QueryString["d"];
                CalenderP cp = new CalenderP(userid, date, month.ToString(), year);

                //get all info
                string fullname = cp.getUserFullname();
                evList.Text = cp.getEventList();
                cardList.Text = cp.getEventCards();

                //check if fetched data has errors
                if (cp.serverResponse == "500")
                {
                    Response.Redirect("~/error");
                }
                else
                {
                    idname.Text = fullname;

                    Dt dt = new Dt();
                    lblMonth.Text = dt.getMonthByVal(month);
                    lblYear.Text = year;
                    lblDay.Text = dt.getDayNameByVal(year, month.ToString(), date);
                    lblDate.Text = date;

                    int prevMonth = 0;
                    int prevYear = 0;
                    int nextMonth = 0;
                    int nextYear = 0;
                    if (month == 1)
                    {
                        prevMonth = 12;
                        prevYear = int.Parse(year) - 1;
                        nextMonth = 2;
                        nextYear = int.Parse(year);
                    }
                    else if (month == 12)
                    {
                        prevMonth = 11;
                        prevYear = int.Parse(year);
                        nextMonth = 1;
                        nextYear = int.Parse(year) + 1;
                    }
                    else
                    {
                        prevMonth = month - 1;
                        prevYear = int.Parse(year);
                        nextMonth = month + 1;
                        nextYear = int.Parse(year);
                    }

                    linkPrev.NavigateUrl = "~/calender?y=" + prevYear.ToString() + "&m=" + prevMonth.ToString() + "&d=" + date + "";
                    linkNext.NavigateUrl = "~/calender?y=" + nextYear.ToString() + "&m=" + nextMonth.ToString() + "&d=" + date + "";

                }
            }
            else
            {
                Response.Redirect("~/login");
            }
        }
    }
}