using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_Project_Jagrp
{
    public class Movie : Booking
    {
        //store the movie 
        public void saveMovie(String title, String rate, String year, String cost, String copies, String plot, String genre) {
            String qry = "insert into Movie(Title,Ratting,Year,Cost,Copies,Plot,Genre) values ('" + title + "','" + rate + "','" + year + "','" + cost + "','" + copies + "','" + plot + "','" + genre + "')";
            Sql_Permission(qry);
            MessageBox.Show("Movie detail is stored ");
        }

        //delete  the movie only if it is not booked 
        public void delMovie(int MovID){
            DataTable tbl = new DataTable();
            tbl = Sql_searchPermission("select * from Booking  where MovID="+MovID+ " and Retrn='Issue'");
            if (tbl.Rows.Count == 0)
            {
                String qry = "delete from Movie where MovID=" + MovID + "";
                Sql_Permission(qry);
                MessageBox.Show("Movie is delete from the store ");
            }
            else {
                MessageBox.Show("Movie is booked so can't delete ");
            }
            
        }

        //update the movie 
        public void updateMovie(int MovID,String title, String rate, String year, String cost, String copies, String plot, String genre) {
            String qry = "update Movie set Title='"+title+"',Ratting='"+rate+"',Year='"+year+"',Cost='"+cost+"',Copies='"+copies+"',Plot='"+plot+"',Genre='"+genre+ "' where  MovID=" + MovID + "";
            Sql_Permission(qry);
            MessageBox.Show("Movie detail is Updated in the store ");
        }
    }
}
