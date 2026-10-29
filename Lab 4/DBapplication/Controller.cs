using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public int InsertMovie(string title, string genre, int duration)
        {
            string query = "INSERT INTO Movie (Title, Genre, Duration) " +
                            "Values ('" + title + "','" + genre + "'," + duration + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateMovieDuration(int movieID, int duration)
        {
            string query = "UPDATE Movie SET Duration=" + duration + " WHERE MovieID=" + movieID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectMoviesByGenre(string genre)
        {
            string query = "SELECT * FROM Movie WHERE Genre='" + genre + "';";
            return dbMan.ExecuteReader(query);
        }

        public int CountMovieShowtimes(int movieID)
        {
            string query = "SELECT COUNT(ShowID) FROM Showtime WHERE MovieNo=" + movieID + ";";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int DeleteShowtime(int showID)
        {
            string query = "DELETE FROM Showtime WHERE ShowID=" + showID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
