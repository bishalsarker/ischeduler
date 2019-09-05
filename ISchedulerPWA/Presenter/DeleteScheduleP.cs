using ISchedulerPWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class DeleteScheduleP
    {
        string schedule_id;
        public string response;
        public DeleteScheduleP(string id)
        {
            this.schedule_id = id;
            delSch();
        }

        private void delSch()
        {
            ScheduleM sm = new ScheduleM();
            NoteM nm = new NoteM();
            nm.schedule_id = this.schedule_id;
            sm.schedule_id = this.schedule_id;
            nm.deleteNoteBySchId();
            sm.deleteSch();
            

            if (sm.response == "500" || nm.response == "500")
            {
                response = "500";
            }
        }
    }
}