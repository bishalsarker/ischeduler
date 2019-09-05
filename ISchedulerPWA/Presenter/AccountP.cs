using ISchedulerPWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class AccountP
    {
        public string user_id;
        public string serverResponse;

        public AccountP(string id)
        {
            this.user_id = id;
        }

        public string getUserFullname()
        {
            UserM um = new UserM();
            um.user_id = this.user_id;
            um = um.getUserByUserId();
            if (um.response == "500")
            {
                serverResponse = "500";
                return "";
            }
            else
            {
                return um.fullname;
            }
        }
    }
}