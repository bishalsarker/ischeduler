using ISchedulerPWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class LoginP
    {
        private string username;
        private string password;
        private List<string> errList = new List<string>();

        public LoginP(string un, string pass)
        {
            this.username = un;
            this.password = pass;
            validateUser();
        }

        private void validateUser()
        {
            UserM rm = new UserM();
            rm.username = this.username;
            rm.password = this.password;
            bool checkIfExists = rm.checkIfUserExists();

            if (checkIfExists == false && rm.response == "500")
            {
                errList.Add("500");
            }
            else if (checkIfExists == false && rm.response == "200")
            {
                errList.Add("Wrong username or password");
            }
            else
            {
                errList.Add("");
            }
        }

        public bool checkIfHasErrors()
        {
            if (errList[0] == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string getUserId()
        {
            UserM um = new UserM();
            um.username = this.username;
            um = um.getUserByUsername();
            return um.user_id;
        }
        public List<string> getErrors()
        {
            return errList;
        }
    }
}