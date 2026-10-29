using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Cinema : Form
    {
        Controller controllerObj;
        public Cinema()
        {
            InitializeComponent();
        }

        private void Cinema_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            // Validate that the title is not empty
            if (titleTextBox.Text == "")
            {
                MessageBox.Show("Please enter the movie title");
                return;
            }
            // TryParse in order to prevent exception if non-integer value was entered
            int duration;
            if (!int.TryParse(durationTextBox.Text, out duration) || duration <= 0)
            {
                MessageBox.Show("Duration should be a positive integer");
                return;
            }

            int result = controllerObj.InsertMovie(titleTextBox.Text, genreTextBox.Text, duration);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new movie failed");
            }
            else
            {
                MessageBox.Show("The movie is inserted successfully!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int movieID, duration;
            if (!int.TryParse(movieIDUpdateTextBox.Text, out movieID))
            {
                MessageBox.Show("Movie ID should be an integer");
                return;
            }
            if (!int.TryParse(durationUpdateTextBox.Text, out duration) || duration <= 0)
            {
                MessageBox.Show("Duration should be a positive integer");
                return;
            }

            int result = controllerObj.UpdateMovieDuration(movieID, duration);
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The movie is updated successfully!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int showID;
            if (!int.TryParse(showIDDeleteTextBox.Text, out showID))
            {
                MessageBox.Show("Show ID should be an integer");
                return;
            }

            int result = controllerObj.DeleteShowtime(showID);
            if (result == 0)
            {
                MessageBox.Show("No rows are deleted");
            }
            else
            {
                MessageBox.Show("The showtime is deleted successfully!");
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            int movieID;
            if (!int.TryParse(movieIDCountTextBox.Text, out movieID))
            {
                MessageBox.Show("Movie ID should be an integer");
                return;
            }
            // NOTE: CountMovieShowtimes returns int, so the result is converted to string to be shown in the form
            countTextBox.Text = controllerObj.CountMovieShowtimes(movieID).ToString();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (genreSelectTextBox.Text == "")
            {
                MessageBox.Show("Please enter a genre");
                return;
            }
            DataTable dt = controllerObj.SelectMoviesByGenre(genreSelectTextBox.Text);
            if (dt == null)
            {
                MessageBox.Show("No movies found in this genre");
            }
            resultDataGrid.DataSource = dt;
            resultDataGrid.Refresh();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            controllerObj.TerminateConnection();
            this.Close();
        }
    }
}
