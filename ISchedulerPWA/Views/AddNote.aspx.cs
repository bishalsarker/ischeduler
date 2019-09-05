using ISchedulerPWA.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISchedulerPWA.Views
{
    public partial class AddNote : System.Web.UI.Page
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
                    if (Request.QueryString["sid"] == null)
                    {
                        Response.Redirect("~/login");
                    }
                    else
                    {
                        idname.Text = fullname;
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
            AddNoteP anp = new AddNoteP(txtTitle.Text, noteBody.InnerHtml, Request.QueryString["sid"]);
            if (anp.response == "500")
            {
                Response.Redirect("~/error");
            }
            else
            {
                Response.Redirect("~/view/schedule?sid=" + Request.QueryString["sid"]);
            }
        }
    }
}