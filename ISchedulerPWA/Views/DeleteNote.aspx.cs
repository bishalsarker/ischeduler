using ISchedulerPWA.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISchedulerPWA.Views
{
    public partial class DeleteNote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                string nid = Request.QueryString["nid"];
                DeleteNoteP dsp = new DeleteNoteP(nid);
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