using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_Project_Jagrp
{
  public class Booking :Client
    {


        public int getNoCopies(int MovID)
        {
            DataTable tbl = new DataTable();
            String qry = "select * from Movie where MovID="+MovID+"";
            tbl = Sql_searchPermission(qry);
            return Convert.ToInt32(tbl.Rows[0]["Copies"].ToString());
        }

        public int getMovieCharges(int MovID)
        {
            DataTable tbl = new DataTable();
            String qry = "select * from Movie where MovID=" + MovID + "";
            tbl = Sql_searchPermission(qry);
            return Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());
        }


        public int getBookedCopies(int MovID)
        {
            DataTable tbl = new DataTable();
            String qry = "select * from Booking where MovID=" + MovID + " and Retrn='Issue'";
            tbl = Sql_searchPermission(qry);
            return tbl.Rows.Count-1;
        }

        public int getClientBooked(int CustID)
        {
            DataTable tbl = new DataTable();
            String qry = "select * from Booking where CustID=" + CustID + " and Retrn='Issue'";
            tbl = Sql_searchPermission(qry);
            return tbl.Rows.Count - 1;
        }



        public void BookMovie(int CustID,int MovID,String issue) {
            if (getBookedCopies(MovID) < getNoCopies(MovID))
            {
                if (getClientBooked(CustID) < 2)
                {
                    String qry = "insert into Booking (CustID,MovID,Issue,Retrn) values ('" + CustID + "','" + MovID + "','" + issue + "','Issue')";
                    Sql_Permission(qry);
                    MessageBox.Show("Movie is Booked by the Client ");
                }
                else {
                    MessageBox.Show("You can't issue more movie ");
                }
                
            }
            else {
                MessageBox.Show("Sorry All Sample are booked ");
            }

        }

        public void DelBookedMovie(int RentID)
        {
            String qry = "delete from Booking where RentID="+RentID+"";
            Sql_Permission(qry);
            MessageBox.Show("Booked Movie is delete from the Store ");
        }

        public void return_Movie(int RentID,int CustID, int MovID, String issue,String Retrn) {

            //get the difference between 
            //get the difference in days between 2 dates and get  the cost from the database 
            DateTime start = Convert.ToDateTime(issue);

            DateTime endDate = Convert.ToDateTime(Retrn);

            String diff2 = (endDate - start).TotalDays.ToString();
            //convert the string value to double 
            double d = Convert.ToDouble(diff2);
            //pass the roud off value to calculate 
            double days = Math.Round(d);
            if (days < 1)
            {
                days = 1;
            }
            

            string qry = "update Booking set  CustID='" + CustID + "',MovID='" + MovID + "',Issue='" + issue + "',Retrn='"+Retrn+ "'  where RentID=" + RentID + "";
            Sql_Permission(qry);
            int payment = Convert.ToInt32(days) * getMovieCharges(MovID);

            MessageBox.Show("Movie is Returned to the Store and charges is $"+payment);
        }

        //get the data from the paramterzied table and show in the grid view 
        public void getRecord(DataGridView dgv,String Table) {
            DataTable tbl = new DataTable();
            tbl = Sql_searchPermission("select * from " + Table + "");
            dgv.DataSource = tbl;
        }
    }
}
