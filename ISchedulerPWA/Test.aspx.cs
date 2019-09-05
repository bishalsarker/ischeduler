using ISchedulerPWA.Models;
using ISchedulerPWA.Presenter;
using ISchedulerPWA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ISchedulerPWA
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            Dt dt = new Dt();
            Label1.Text = dt.getHourVal() + dt.getMinuteVal() + dt.getTimeVal();
             * */
            ScheduleViewerP sp = new ScheduleViewerP();
            sp.id = "13";
            Label1.Text = sp.getNoteList();
        }
    }
}