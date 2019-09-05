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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Dt dt = new Dt();
                string year = dt.getYearVal().ToString();
                string month = dt.getMonthVal().ToString();
                string date = dt.getDayVal().ToString();
                Response.Redirect("~/calender?y=" + year + "&m=" + month + "&d=" + date + "");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            LoginP lp = new LoginP(txtUsername.Text, txtPassword.Text);
            if (lp.checkIfHasErrors() == true)
            {
                if (lp.getErrors()[0] == "500")
                {
                    Response.Redirect("~/error");
                }
                else
                {
                    err.Text = lp.getErrors()[0];
                }
            }
            else
            {
                Session["user"] = lp.getUserId();
                Dt dt = new Dt();
                string year = dt.getYearVal().ToString();
                string month = dt.getMonthVal().ToString();
                string date = dt.getDayVal().ToString();
                Response.Redirect("~/calender?y=" + year + "&m=" + month + "&d=" + date + "");
            }
        }
    }
}