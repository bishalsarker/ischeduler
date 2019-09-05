using ISchedulerPWA.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISchedulerPWA.Views
{
    public partial class DeleteSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                string sid = Request.QueryString["sid"];
                DeleteScheduleP dsp = new DeleteScheduleP(sid);
                if (dsp.response == "500")
                {
                    Response.Redirect("~/error");
                }
                else
                {
                    Response.Redirect("~/login");
                }
            }
            else
            {
                Response.Redirect("~/login");
            }
        }
    }
}