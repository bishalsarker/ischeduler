using ISchedulerPWA.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISchedulerPWA.Views
{
    public partial class ScheduleViewer : System.Web.UI.Page
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
                    ScheduleViewerP viewInfo = new ScheduleViewerP();
                    viewInfo.id = Request.QueryString["sid"];
                    viewInfo = viewInfo.getInfo();
                    if (viewInfo.response == "500")
                    {
                        Response.Redirect("~/error");
                    }
                    else
                    {
                        lblTitle.Text = viewInfo.title;
                        lblDay.Text = viewInfo.date;
                        lblTime.Text = viewInfo.time;
                        lblLoc.Text = viewInfo.location;
                        lblPriority.Text = viewInfo.priority;

                        viewInfo.id = Request.QueryString["sid"];
                        noteList.Text = viewInfo.getNoteList();

                        editLink.NavigateUrl = "/editSchedule?sid=" + Request.QueryString["sid"];
                        deleteLink.NavigateUrl = "/deleteSchedule?sid=" + Request.QueryString["sid"];
                        addNoteLink.NavigateUrl = "/addNote?sid=" + Request.QueryString["sid"];
                    }
                }
            }
            else
            {
                Response.Redirect("~/login");
            }
        }
    }
}