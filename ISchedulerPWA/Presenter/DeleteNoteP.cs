using ISchedulerPWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class DeleteNoteP
    {
        string note_id;
        public string response;
        public DeleteNoteP(string i)
        {
            this.note_id = i;
            delete();
        }

        private void delete()
        {
            NoteM nm = new NoteM();
            nm.note_id = this.note_id;
            nm.deleteNote();

            if (nm.response == "500")
            {
                this.response = "500";
            }
        }
    }
}