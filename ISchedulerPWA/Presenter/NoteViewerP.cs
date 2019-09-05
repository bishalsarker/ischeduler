using ISchedulerPWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class NoteViewerP
    {
        public string note_id;
        public string note_title;
        public string note;
        public string schedule_id;
        public string response;

        /*
        public NoteViewerP() {}
        public NoteViewerP(string i, string t, string n, string sid)
        {
            this.note_id = i;
            this.note_title = t;
            this.note = n;
            this.schedule_id = sid;
        }
        */
        public NoteViewerP getNote()
        {
            NoteViewerP nmp = new NoteViewerP();
            NoteM nm = new NoteM();
            nm.note_id = this.note_id;
            nm = nm.getNoteById();

            if (nm.response == "500")
            {
                nmp.response = "500";
            }
            else
            {
                nmp.note_title = nm.note_title;
                nmp.note = nm.note;
            }

            return nmp;
        }
    }
}