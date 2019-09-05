using ISchedulerPWA.Models;
using ISchedulerPWA.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Presenter
{
    public class ScheduleViewerP
    {
        public string id;
        public string title;
        public string date;
        public string time;
        public string location;
        public string priority;
        public string response;

        public ScheduleViewerP getInfo()
        {
            ScheduleViewerP info = new ScheduleViewerP();
            ScheduleM sm = new ScheduleM();
            sm.schedule_id = this.id;
            sm = sm.getSchedulesById();

            Dt dt = new Dt();
            
            info.title = sm.schedule_title;
            info.date = dt.getMonthByVal(int.Parse(sm.month)) + " " + sm.date + ", " + sm.year;
            info.time = sm.hour + ":" + sm.minute + " " + sm.time;
            info.location = sm.location;
            if (sm.priority == "1")
            {
                info.priority = "High";
            }

            if (sm.priority == "2")
            {
                info.priority = "Medium";
            }

            if (sm.priority == "3")
            {
                info.priority = "Low";
            }

            if (sm.response == "500")
            {
                info.response = "500";
            }

            return info;
        }
        public string getNoteList()
        {
            string noteList = "";
            NoteM note = new NoteM();
            note.schedule_id = this.id;

            foreach (NoteM n in note.getAllNotes())
            {
                noteList = noteList + "<ul class='note-list'>"+
                                      "<li><a href='/view/note?nid=" + n.note_id + 
                                      "'><div class='note-list-title'>" +
                                      n.note_title + "</div></a></li></ul>";				
            }

            if (note.response == "500")
            {
                return "Error!";
            }
            else
            {
                return noteList;
            }
        }
    }
}