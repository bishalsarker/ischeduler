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
    public partial class EditSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                string userid = Session["user"].ToString();
                AccountP acc = new AccountP(userid);

                //get all info
                string fullname = acc.getUserFullname();

                //check if fetched data has errors
                if (acc.serverResponse == "500")
                {
                    Response.Redirect("~/error");
                }
                else
                {
                    idname.Text = fullname;

                    //get days
                    int i = 1;
                    while (i < 32)
                    {
                        ddList.Items.Add(new ListItem(i.ToString(), i.ToString()));
                        i++;
                    }

                    //get months
                    int j = 1;
                    while (j < 13)
                    {
                        Dt dt = new Dt();
                        string monthName = dt.getMonthByVal(j);
                        mmList.Items.Add(new ListItem(monthName, j.ToString()));
                        j++;
                    }

                    //get years
                    int k = 0;
                    int year = 2018;
                    yyList.Items.Add(new ListItem(year.ToString(), year.ToString()));
                    while (k < 10)
                    {
                        year = year + 1;
                        yyList.Items.Add(new ListItem(year.ToString(), year.ToString()));
                        k++;
                    }

                    //get hours
                    int m = 1;
                    while (m < 13)
                    {
                        if (m < 10)
                        {
                            hList.Items.Add(new ListItem("0" + m.ToString(), "0" + m.ToString()));
                        }
                        else
                        {
                            hList.Items.Add(new ListItem(m.ToString(), m.ToString()));
                        }
                        m++;
                    }

                    //get minutes
                    int n = 0;
                    while (n < 60)
                    {
                        if (n < 10)
                        {
                            mList.Items.Add(new ListItem("0" + n.ToString(), "0" + n.ToString()));
                        }
                        else
                        {
                            mList.Items.Add(new ListItem(n.ToString(), n.ToString()));
                        }
                        n++;
                    }

                    //am pm
                    tList.Items.Add(new ListItem("am", "AM"));
                    tList.Items.Add(new ListItem("pm", "PM"));

                    //priority list
                    pList.Items.Add(new ListItem("High", "1"));
                    pList.Items.Add(new ListItem("Medium", "2"));
                    pList.Items.Add(new ListItem("Low", "3"));

                    //repeat list
                    rList.Items.Add(new ListItem("No repeat", "1"));
                    rList.Items.Add(new ListItem("Daily", "2"));
                    rList.Items.Add(new ListItem("Weekly", "3"));
                    rList.Items.Add(new ListItem("Monthly", "4"));
                    rList.Items.Add(new ListItem("Yearly", "5"));

                    //set defaults
                    if (!IsPostBack)
                    {
                        EditScheduleP es = new EditScheduleP();
                        es = es.getSch(Request.QueryString["sid"]);
                        schTitle.Text = es.schedule_title;
                        ddList.SelectedValue = es.date;
                        mmList.SelectedValue = es.month;
                        yyList.SelectedValue = es.year;
                        hList.SelectedValue = es.hour;
                        mList.SelectedValue = es.minute;
                        tList.SelectedValue = es.time;
                        schLoc.Text = es.location;
                        pList.SelectedValue = es.priority;
                        rList.SelectedValue = es.repeat;
                        
                    }
                }
            }
            else
            {
                Response.Redirect("~/login");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            string schedule_title = schTitle.Text;
            string date = ddList.Text;
            string month = mmList.Text;
            string year = yyList.Text;
            string hour = hList.Text;
            string minute = mList.Text;
            string time = tList.Text;
            string location = schLoc.Text;
            string priority = pList.Text;
            string repeat = rList.Text;
            string sid = Request.QueryString["sid"];

            EditScheduleP addSch = new EditScheduleP(
            schedule_title,
            date,
            month,
            year,
            hour,
            minute,
            time,
            location,
            priority,
            repeat,
            sid
            );

            if (addSch.serverResponse == "500")
            {
                Response.Redirect("~/error");
            }
            else
            {
                Response.Redirect("~/view/schedule?sid=" + sid + "");
            }
        }
    }
}