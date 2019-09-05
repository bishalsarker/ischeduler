using ISchedulerPWA.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISchedulerPWA.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            RegisterP rp = new RegisterP(
                txtName.Text, 
                txtUsername.Text, 
                txtEmail.Text,
                txtPassword.Text, 
                txtRetypePassword.Text
            );

            if(rp.checkIfHasErrors() == true)
            {
                //Validation Errors
                errName.Text = rp.getErrors()[0];
                errUsername.Text = rp.getErrors()[1];
                errEmail.Text = rp.getErrors()[2];
                errPassword.Text = rp.getErrors()[3];
                errRetypePassword.Text = rp.getErrors()[4];

                //Server Error
                if(rp.getErrors()[5] != "")
                {
                    Response.Redirect("~/error");
                }
            }
            else
            {
                Response.Redirect("~/congrats");
            }
        }
    }
}