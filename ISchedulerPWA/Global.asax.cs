using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ISchedulerPWA
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "Home",
                "",
                "~/Views/Home.aspx"
            );

            routes.MapPageRoute(
                "Default",
                "calender",
                "~/Views/Calender.aspx"
            );

            routes.MapPageRoute(
                "Add Schedule",
                "addSchedule",
                "~/Views/AddSchedule.aspx"
            );

            routes.MapPageRoute(
                "Edit Schedule",
                "editSchedule",
                "~/Views/EditSchedule.aspx"
            );

            routes.MapPageRoute(
                "Delete Schedule",
                "deleteSchedule",
                "~/Views/DeleteSchedule.aspx"
            );

            routes.MapPageRoute(
                "Schedule Viewer",
                "view/schedule",
                "~/Views/ScheduleViewer.aspx"
            );

            routes.MapPageRoute(
                "Add Note",
                "addNote",
                "~/Views/AddNote.aspx"
            );

            routes.MapPageRoute(
                "Delete Note",
                "deleteNote",
                "~/Views/DeleteNote.aspx"
            );

            routes.MapPageRoute(
                "Note Viewer",
                "view/note",
                "~/Views/NoteViewer.aspx"
            );

            routes.MapPageRoute(
                "Login",
                "login",
                "~/Views/Login.aspx"
            );

            routes.MapPageRoute(
                "User Registration",
                "signup",
                "~/Views/Register.aspx"
            );

            routes.MapPageRoute(
                "Logout",
                "logout",
                "~/Views/Logout.aspx"
            );

            routes.MapPageRoute(
                "Server Error",
                "error",
                "~/Views/Error.aspx"
            );

            routes.MapPageRoute(
                "Reg Success",
                "congrats",
                "~/Views/Congratulations.aspx"
            );
        }
    }
}