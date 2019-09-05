using ISchedulerPWA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class AddNoteP
    {
       string note_id;
       string note_title;
       string note;
       string schedule_id;
       public string response;

       public AddNoteP(string t, string n, string sid)
       {
           if (t == "")
           {
               this.note_title = "My note";
           }
           else
           {
               this.note_title = t;
           }
           this.note = n;
           this.schedule_id = sid;
           addN();
       }
       private void addN()
       {
           NoteM nm = new NoteM();
           nm.note_title = this.note_title;
           nm.note = this.note;
           nm.schedule_id = this.schedule_id;
           nm.addNote();

           if (nm.response == "500")
           {
               this.response = "500";
           }
       }
       public string getRecent()
       {
           NoteM nm = new NoteM();
           nm.schedule_id = this.schedule_id;
           return nm.getLastInsertedNotId();
       }
    }
}