using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace SimpleDataApp
{
   public partial class FillOrCancel : Form
   {
      //Storage for OrderID
      private int parseOrderID;

      //Specify connection string
      string connstr = Utility.GetConnectionString();

      public FillOrCancel()
      {
         InitializeComponent();
      }

      //Verify that OrderID is ready
      private bool isOrderID()
      {
         //Check for input in the orderID textbox
         if (txtOrderID.Text == "")
         {
            MessageBox.Show("Please enter an Order ID");
            return false;
         }
         //Check for characters other than integers.
         else if (Regex.IsMatch(txtOrderID.Text, @"^\D*$"))
         {
            //Show message and clear input
            MessageBox.Show("Integers only");
            txtOrderID.Clear();
            return false;
         }
         else
         {
            //Convert the textbox input to an integer
            parseOrderID = Int32.Parse(txtOrderID.Text);
            return true;
         }
      }

      //Find an order
      private void btnFindByOrderID_Click(object sender, EventArgs e)
      {
         //Create connection
         SqlConnection conn = new SqlConnection(connstr);

         //Define a query string that has a parameter for orderID
         string sql = "select * from Sales.Orders where orderID = @orderID";

         //Create a SqlCommand object
         SqlCommand cmdOrderID = new SqlCommand(sql, conn);

         //Define the orderID parameter and its value
         cmdOrderID.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
         cmdOrderID.Parameters["@orderID"].Value = parseOrderID;

         //Run the command and display the results
         try
         {
            //Open the connection
            conn.Open();

            //Run the sql command
            SqlDataReader rdr = cmdOrderID.ExecuteReader();

            //Create a data table to hold the results
            DataTable dataTable = new DataTable();

            //Load the data drom SqlDataReader
            dataTable.Load(rdr);

            //Display the data from the table in the data grid view
            this.dgvCustomerOrders.DataSource = dataTable;

            rdr.Close();
         }
         catch
         {
            MessageBox.Show("The requested order could not be loaded into the form");
         }
         finally
         {
            conn.Close();
         }
      }

      //Cancel an order
      private void btnCancelOrder_Click(object sender, EventArgs e)
      {
         //run sp only if orderID is ready
         if (isOrderID())
         {
            //Create the connection
            SqlConnection conn = new SqlConnection(connstr);

            //Create command and identify it as a stored procedure
            SqlCommand cmdCancelOrder = new SqlCommand("Sales.uspCancelOrder", conn);
            cmdCancelOrder.CommandType = CommandType.StoredProcedure;

            //Add parameter orderID
            cmdCancelOrder.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
            cmdCancelOrder.Parameters["@orderID"].Value = parseOrderID;

            //Execute the sp cmdCancelOrder
            try
            {
               //Open Connection
               conn.Open();

               //Run th e command
               cmdCancelOrder.ExecuteNonQuery();
            }
            catch
            {
               MessageBox.Show("The cancel operation was not completed");
            }
            finally
            {
               conn.Close();
            }
         }
      }

      //Fill an order
      private void btnFillOrder_Click(object sender, EventArgs e)
      {
         //run sp only if OrderID is ready
         if (isOrderID())
         {
            //Create Connection
            SqlConnection conn = new SqlConnection(connstr);

            //Create command and identify as stored procedure
            SqlCommand cmdFillOrder = new SqlCommand("Sales.uspFillOrder", conn);
            cmdFillOrder.CommandType = CommandType.StoredProcedure;

            //Add input parameter
            //orderID
            cmdFillOrder.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
            cmdFillOrder.Parameters["@orderID"].Value = parseOrderID;

            //FilledDate
            cmdFillOrder.Parameters.Add(new SqlParameter("@FilledDate", SqlDbType.DateTime, 8));
            cmdFillOrder.Parameters["@FilledDate"].Value = dtpFillDate.Value;

            //Try running the command
            try
            {
               //Open the connection
               conn.Open();

               //Exec the command
               cmdFillOrder.ExecuteNonQuery();
            }
            catch
            {
               MessageBox.Show("The fill operation was not completed.");
            }
            finally
            {
               //Close connection
               conn.Close();
            }
         }
      }

      private void btnFinishUpdates_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
