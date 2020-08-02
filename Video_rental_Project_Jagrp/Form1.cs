using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_Project_Jagrp
{
    public partial class Form1 : Form
    {
        int RentID = 0;
        Movie client = new Movie();
        int option = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_cust_Click(object sender, EventArgs e)
        {
            if (!cus_name.Text.Equals("") && !cus_email.Text.Equals("") && !cus_ph.Text.Equals("") && !cus_address.Text.Equals(""))
            {
                client.SaveClient(cus_name.Text, cus_email.Text, cus_ph.Text, cus_address.Text);
                cus_name.Text = ""; cus_address.Text = ""; cus_email.Text = ""; cus_ph.Text = "";
            }
            else {
                MessageBox.Show("Must fill all details ");
            }
        }

        private void del_cust_Click(object sender, EventArgs e)
        {
            //first of all select the client afte that we can delete his record if he didn't have any movie booked
            if (!cus_id.Text.Equals("")) {
                client.deleteClient(Convert.ToInt32(cus_id.Text.ToString()));
            } else{
                MessageBox.Show("Must select the CLient to delete his record ");
            }

            cus_id.Text = "";
            cus_name.Text = ""; cus_address.Text = ""; cus_email.Text = ""; cus_ph.Text = "";

        }

        private void update_del_Click(object sender, EventArgs e)
        {
            //first of all select the client afte that we can delete his record if he didn't have any movie booked
            if (!cus_id.Text.Equals(""))
            {
                client.UpdateClient(Convert.ToInt32(cus_id.Text.ToString()),cus_name.Text, cus_email.Text, cus_ph.Text, cus_address.Text);
            }
            else
            {
                MessageBox.Show("Must select the CLient to delete his record ");
            }

            cus_id.Text = "";
            cus_name.Text = ""; cus_address.Text = ""; cus_email.Text = ""; cus_ph.Text = "";

        }



        private void issue_mov_Click(object sender, EventArgs e)
        {
            if (!cus_id.Text.Equals("") && !mov_id.Text.Equals(""))
            {
                client.BookMovie(Convert.ToInt32(cus_id.Text.ToString()), Convert.ToInt32(mov_id.Text.ToString()), ise_Date.Text);
            }
            else {
                MessageBox.Show("you must have to select both movie and client to book ");
            }

            cus_id.Text = "";
            cus_name.Text = ""; cus_address.Text = ""; cus_email.Text = ""; cus_ph.Text = "";
            mov_id.Text = "";
            title.Text = "";rate_video.Text = "";realease_year.Text = "";copies.Text = "";cost.Text = ""; genre.Text = "";plot.Text = "";
        }

        private void del_movie_Click(object sender, EventArgs e)
        {
            //first of all select the booked movie to delete 
            if (RentID>0) {
                client.DelBookedMovie(RentID);
                
            }
            else {
                MessageBox.Show("First Select Booked Movie to Delete ");
            }

            cus_id.Text = "";
            cus_name.Text = ""; cus_address.Text = ""; cus_email.Text = ""; cus_ph.Text = "";
            mov_id.Text = "";
            title.Text = ""; rate_video.Text = ""; realease_year.Text = ""; copies.Text = ""; cost.Text = ""; genre.Text = ""; plot.Text = "";
            RentID = 0;
        }

        private void return_mov_Click(object sender, EventArgs e)
        {
            if (!cus_id.Text.Equals("") && !mov_id.Text.Equals(""))
            {
                client.return_Movie(RentID,Convert.ToInt32(cus_id.Text.ToString()), Convert.ToInt32(mov_id.Text.ToString()), ise_Date.Text,retrn_Date.Text);
            }
            else
            {
                MessageBox.Show("you must have to select both movie and client to book ");
            }

            cus_id.Text = "";
            cus_name.Text = ""; cus_address.Text = ""; cus_email.Text = ""; cus_ph.Text = "";
            mov_id.Text = "";
            title.Text = ""; rate_video.Text = ""; realease_year.Text = ""; copies.Text = ""; cost.Text = ""; genre.Text = ""; plot.Text = "";

            RentID = 0;
        }

        private void video_add_Click(object sender, EventArgs e)
        {
            if (!title.Text.Equals("") && !rate_video.Text.Equals("") && !realease_year.Text.Equals("") && !cost.Text.Equals("") && !copies.Text.Equals("") && !plot.Text.Equals("") && !genre.Text.Equals("")) {
                client.saveMovie(title.Text,rate_video.Text,realease_year.Text,cost.Text,copies.Text,plot.Text,genre.Text);
                
            } else{
                MessageBox.Show("Must fill all the values ");
            }

            mov_id.Text = "";
            title.Text = ""; rate_video.Text = ""; realease_year.Text = ""; copies.Text = ""; cost.Text = ""; genre.Text = ""; plot.Text = "";

        }

        private void realease_year_TextChanged(object sender, EventArgs e)
        {
            try {
                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;
                int cst = 0;

                int diffYear = Currentyear - Convert.ToInt32(realease_year.Text);
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cst = 2;
                }
                else if (diffYear >= 0 && diffYear < 5)
                {
                    cst = 5;
                }

               cost.Text = "" + cst;


            }
            catch (Exception ex) {
                    
            }

        }

        private void video_del_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(mov_id.Text.ToString()) > 0)
            {
                client.delMovie(Convert.ToInt32(mov_id.Text.ToString()));
            }
            else {
                MessageBox.Show("must select the Movie to delete ");
            }

            mov_id.Text = "";
            title.Text = ""; rate_video.Text = ""; realease_year.Text = ""; copies.Text = ""; cost.Text = ""; genre.Text = ""; plot.Text = "";
            cus_id.Text = "";
            cus_name.Text = ""; cus_address.Text = ""; cus_email.Text = ""; cus_ph.Text = "";



        }

        private void video_update_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(mov_id.Text.ToString())>0 && !title.Text.Equals("") && !rate_video.Text.Equals("") && !realease_year.Text.Equals("") && !cost.Text.Equals("") && !copies.Text.Equals("") && !plot.Text.Equals("") && !genre.Text.Equals(""))
            {
                client.updateMovie(Convert.ToInt32(mov_id.Text.ToString()),title.Text, rate_video.Text, realease_year.Text, cost.Text, copies.Text, plot.Text, genre.Text);

            }
            else
            {
                MessageBox.Show("Must fill and select all the values ");
            }

            mov_id.Text = "";
            title.Text = ""; rate_video.Text = ""; realease_year.Text = ""; copies.Text = ""; cost.Text = ""; genre.Text = ""; plot.Text = "";



        }

        private void data_customer_Click(object sender, EventArgs e)
        {
            option = 1;

            client.getRecord(DatabaseTable,"client");
        }

        private void data_video_Click(object sender, EventArgs e)
        {
            client.getRecord(DatabaseTable, "Movie");
            option = 2;
        }

        private void data_rental_Click(object sender, EventArgs e)
        {
            client.getRecord(DatabaseTable, "Booking");
            option = 3;
        }

        private void data_pop_movie_Click(object sender, EventArgs e)
        {

            client.bestMovie();
        }

        private void data_pop_customer_Click(object sender, EventArgs e)
        {
            client.bestClient();
        }

        private void DatabaseTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (option == 1)
            {
                //get the details of the client 
                cus_id.Text = DatabaseTable.CurrentRow.Cells[0].Value.ToString();
                cus_name.Text = DatabaseTable.CurrentRow.Cells[1].Value.ToString();
                cus_email.Text = DatabaseTable.CurrentRow.Cells[2].Value.ToString();
                cus_ph.Text = DatabaseTable.CurrentRow.Cells[3].Value.ToString();
                cus_address.Text = DatabaseTable.CurrentRow.Cells[4].Value.ToString();
            }
            else if (option == 2)
            {
                //gett he movie details 
                mov_id.Text = DatabaseTable.CurrentRow.Cells[0].Value.ToString();
                title.Text = DatabaseTable.CurrentRow.Cells[1].Value.ToString();
                rate_video.Text = DatabaseTable.CurrentRow.Cells[2].Value.ToString();
                realease_year.Text = DatabaseTable.CurrentRow.Cells[3].Value.ToString();
                cost.Text = DatabaseTable.CurrentRow.Cells[4].Value.ToString();
                copies.Text = DatabaseTable.CurrentRow.Cells[5].Value.ToString();
                plot.Text = DatabaseTable.CurrentRow.Cells[6].Value.ToString();
                genre.Text = DatabaseTable.CurrentRow.Cells[7].Value.ToString();

            }
            else if (option == 3)
            {
                RentID=Convert.ToInt32( DatabaseTable.CurrentRow.Cells[0].Value.ToString());
                cus_id.Text = DatabaseTable.CurrentRow.Cells[1].Value.ToString();
                mov_id.Text = DatabaseTable.CurrentRow.Cells[2].Value.ToString();
                ise_Date.Text = DatabaseTable.CurrentRow.Cells[3].Value.ToString();

            }
            else {
                MessageBox.Show("must choose an option ");
            }
            option = 0;
        }
    }
}
