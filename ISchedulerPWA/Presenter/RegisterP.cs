using ISchedulerPWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class RegisterP
    {
        private string fullname;
        private string username;
        private string email;
        private string password;
        private string retypePassword;
        private List<string> errList = new List<string>();

        public RegisterP(string fn, string un, string em, string pass, string rePass)
        {
            this.fullname = fn;
            this.username = un;
            this.email = em;
            this.password = pass;
            this.retypePassword = rePass;
            checkForValidationErrors();
            registerUser();
        }

        private void checkForValidationErrors()
        {
            //Valid name
            if(this.fullname == "" || this.fullname == null)
            {
                errList.Add("Your name is required!");
            }
            else
            {
                errList.Add("");
            }

            //Valid username
            if (this.username == "" || this.username == null)
            {
                errList.Add("Username is required!");
            }
            else if(checkForValidUsername() == false)
            {
                errList.Add("Username exists!");
            }
            else
            {
                errList.Add("");
            }

            //Valid email
            if (this.email == "" || this.email == null)
            {
                errList.Add("Email is required!");
            }
            else
            {
                errList.Add("");
            }

            //Valid Password
            if (this.password == "" || this.password == null)
            {
                errList.Add("Password is required!");
            }
            else
            {
                errList.Add("");
            }

            //Check if password matched
            if (this.password != this.retypePassword)
            {
                errList.Add("Passwords didn't mathced!");
            }
            else
            {
                errList.Add("");
            }
        }
        private void registerUser()
        {
            if(checkIfHasValidationErrors() == false)
            {
                UserM rm = new UserM();
                rm.fullname = this.fullname;
                rm.username = this.username;
                rm.email = this.email;
                rm.password = this.password;
                rm.addUser();

                if(rm.response == "500")
                {
                    errList.Add("Server Error!");
                }
                else
                {
                    errList.Add("");
                }
            }
            else
            {
                errList.Add("");
            }
        }
        private bool checkIfHasValidationErrors()
        {
            int i = 0;
            bool flag = false;
            while(i < errList.Count())
            {
                if(errList[i] != "")
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                    i++;
                }
            }
            return flag;
        }
        private bool checkForValidUsername()
        {
            UserM rm = new UserM();
            rm.username = this.username;
            if (rm.checkIfUsernameExits() == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkIfHasErrors()
        {
            if(errList.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<string> getErrors()
        {
            return errList;
        }
    }
}