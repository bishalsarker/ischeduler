using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ISchedulerPWA.Models
{
    public class NoteM
    {
        public string note_id;
        public string note_title;
        public string note;
        public string schedule_id;
        public string response;

        SqlConnection conn;

        public NoteM()
        {
            DBConfig db = new DBConfig();
            conn = new SqlConnection(db.getConnStr());
        }
        private bool openConn()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch(SqlException ex)
            {
                return false;
            }
        }
        private bool closeConn()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public void addNote()
        {
            string query = "insert into notes(note_title, note, schedule_id) values('" + this.note_title + "','" + this.note + "','" + this.schedule_id + "')";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                closeConn();
                this.response = "200";
            }
            else
            {
                this.response = "500";
            }
        }
        public NoteM getNoteById()
        {
            NoteM note = new NoteM();
            string query = "select * from notes where note_id='" + this.note_id + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    note.note_title = reader["note_title"] + "";
                    note.note = reader["note"] + "";
                }
                reader.Close();
                closeConn();
                note.response = "200";
            }
            else
            {
                note.response = "500";
            }
            return note;
        }
        public List<NoteM> getAllNotes()
        {
            List<NoteM> notes = new List<NoteM>();
            string query = "select * from notes where schedule_id='" + this.schedule_id + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    notes.Add(new NoteM
                    {
                        note_id = reader["note_id"] + "",
                        note_title = reader["note_title"] + "",
                        note = reader["note"] + ""
                    });
                }
                reader.Close();
                closeConn();
                this.response = "200";
            }
            else
            {
                this.response = "500";
            }
            return notes;
        }
        public void deleteNote()
        {
            string query = "delete from notes where note_id='" + this.note_id + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                closeConn();
                this.response = "200";
            }
            else
            {
                this.response = "500";
            }
        }
        public void deleteNoteBySchId()
        {
            string query = "delete from notes where schedule_id='" + this.schedule_id + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                closeConn();
                this.response = "200";
            }
            else
            {
                this.response = "500";
            }
        }
        public string getLastInsertedNotId(){
            string query = "select max(note_id) from notes where schedule_id='" + this.schedule_id + "'";
            if (openConn() == true)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                string id = cmd.ExecuteScalar().ToString();
                closeConn();
                this.response = "200";
                return id;
            }
            else
            {
                this.response = "500";
                return "0";
            }
        }
    }
}