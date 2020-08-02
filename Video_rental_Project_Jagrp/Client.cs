using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_Project_Jagrp
{
    public class Client:Connection
    {
        public void SaveClient(String Name,String Email,String Mob,String Address) {

            //get the details of the customer from the client and register him in the store 
            String qry = "insert into client(Name,Email,Phone,Address) values ('"+Name+"','"+Email+"','"+Mob+"','"+Address+"')";
            Sql_Permission(qry);
            MessageBox.Show("Client is Registerd in the Store ");

        }



        public void bestClient() {

            //get the Name of the Best Customer of the Store 

            DataTable tblData = new DataTable();
            tblData =Sql_searchPermission("select * from client");
            int x = 0, y = 0, cunt = 0;
            String Name = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tbl = new DataTable();
                tbl =Sql_searchPermission("select * from Booking where CustID=" + Convert.ToInt32(tblData.Rows[x]["CustID"].ToString()) + "");

                if (tbl.Rows.Count > cunt)
                {
                    Name = tblData.Rows[x]["Name"].ToString();
                    cunt = tbl.Rows.Count;
                }
            }
            MessageBox.Show("Best Cusotmer of the Store  is " + Name);
        }


        public void bestMovie()
        {

            //get the Name of the Best Customer of the Store 

            DataTable tblData = new DataTable();
            tblData = Sql_searchPermission("select * from Movie");
            int x = 0, y = 0, cunt = 0;
            String Name = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tbl = new DataTable();
                tbl = Sql_searchPermission("select * from Booking where MovID=" + Convert.ToInt32(tblData.Rows[x]["MovID"].ToString()) + "");

                if (tbl.Rows.Count > cunt)
                {
                    Name = tblData.Rows[x]["Title"].ToString();
                    cunt = tbl.Rows.Count;
                }
            }
            MessageBox.Show("Best Cusotmer of the Store  is " + Name);
        }



        public void deleteClient(int CustID) {

            DataTable tbl = new DataTable();
            tbl = Sql_searchPermission("select * from Booking where CustID=" + CustID + " and Retrn='Issue'");

            if (tbl.Rows.Count == 0)
            {
                //delete the client details 
                String qry = "delete from client where CustID=" + CustID + "";
                Sql_Permission(qry);
                MessageBox.Show("Client record is removed ");

            }
            else {
                MessageBox.Show("First Return the Movie then you can do it ");
            }
            
        }



        public void UpdateClient(int CustID,String Name, String Email, String Mob, String Address)
        {

            //get the details of the customer from the client and register him in the store 
            String qry = "update  client set Name='"+Name+"',Email='"+Email+"',Phone='"+Mob+"',Address='" + Address + "' where  CustID=" + CustID + "";
            Sql_Permission(qry);
            MessageBox.Show("Client details are alter");

        }



    }
}
