using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Models
{
    public class DBConfig
    {
        public string getConnStr()
        {
            return "Data Source=(local);Initial Catalog=ischedulerdb;Integrated Security=SSPI";
        }
    }
}