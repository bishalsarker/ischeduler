using ISchedulerPWA.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISchedulerPWA.Views
{
    public partial class NoteViewer : System.Web.UI.Page
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

                    NoteViewerP viewInfo = new NoteViewerP();
                    viewInfo.note_id = Request.QueryString["nid"];
                    viewInfo = viewInfo.getNote();
                    if (viewInfo.response == "500")
                    {
                        Response.Redirect("~/error");
                    }
                    else
                    {
                        nTitle.Text = viewInfo.note_title;
                        nBody.Text = Server.HtmlDecode(viewInfo.note);
                        
                        editLink.NavigateUrl = "/editNote?nid=" + Request.QueryString["nid"];
                        deleteLink.NavigateUrl = "/deleteNote?nid=" + Request.QueryString["nid"];
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