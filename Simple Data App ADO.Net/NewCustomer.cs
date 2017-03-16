using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SimpleDataApp
{
   public partial class NewCustomer : Form
   {
      //Storage for identity values returned from database
      private int parsedCustomerID;
      private int orderID;

      //Specify a connection string
      string connstr = Utility.GetConnectionString();

      public NewCustomer()
      {
         InitializeComponent();
      }

      //Verify that customer name is present
      private bool isCustomerName()
      {
         if (txtCustomerName.Text == "")
         {
            MessageBox.Show("Please enter a name.");
            return false;
         }
         else
         {
            return true;
         }
      }

      //Create Account
      private void btnCreateAccount_Click(object sender, EventArgs e)
      {
         //Set up and run stored procedure only f customer name is present.
         if (isCustomerName())
         {
            //Create the connection
            SqlConnection conn = new SqlConnection(connstr);

            //Create a SqlCommand and identify it as a stored procedure.
            SqlCommand cmdNewCustomer = new SqlCommand("Sales.uspNewCustomer", conn);
            cmdNewCustomer.CommandType = CommandType.StoredProcedure;

            //Add input parameter from the stored procedure and specify what to use as its value.
            cmdNewCustomer.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
            cmdNewCustomer.Parameters["@CustomerName"].Value = txtCustomerName.Text;

            //Add output parameter
            cmdNewCustomer.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
            cmdNewCustomer.Parameters["@CustomerID"].Direction = ParameterDirection.Output;

            //try-catch-finally
            try
            {
               //Open the connecton
               conn.Open();

               //Run the stored procedure
               cmdNewCustomer.ExecuteNonQuery();

               //Customer ID is an Identity value from the database
               this.parsedCustomerID = (int)cmdNewCustomer.Parameters["@CustomerID"].Value;
               this.txtCustomerID.Text = Convert.ToString(parsedCustomerID);
            }
            catch
            {
               //A simple catch
               MessageBox.Show("Account cannot be created");
            }
            finally
            {
               //Close connection
               conn.Close();
            }
         }
      }

      //Place an order
      private void btnPlaceOrder_Click(object sender, EventArgs e)
      {
         //run procedure only if required input is present
         if (isPlaceOrderReady())
         {
            
            //Create Connection
            SqlConnection conn = new SqlConnection(connstr);

            //Create SqlCommand and identify it as a stored procedure.
            SqlCommand cmdNewOrder = new SqlCommand("Sales.uspPlaceNewOrder", conn);
            cmdNewOrder.CommandType = CommandType.StoredProcedure;

            //Add parameters
            //CustomerID
            cmdNewOrder.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
            cmdNewOrder.Parameters["@CustomerID"].Value = this.parsedCustomerID;

            //OrderDate
            cmdNewOrder.Parameters.Add(new SqlParameter("@OrderDate", SqlDbType.DateTime, 8));
            cmdNewOrder.Parameters["@OrderDate"].Value = dtpOrderDate.Value;

            //Amount
            cmdNewOrder.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
            cmdNewOrder.Parameters["@Amount"].Value = numOrderAmount.Value;

            //Status, for a new order the status is always O (open)
            cmdNewOrder.Parameters.Add(new SqlParameter("@Status", SqlDbType.Char, 1));
            cmdNewOrder.Parameters["@Status"].Value = "O";

            //Add return value for stored procedure, which is orderID
            cmdNewOrder.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
            cmdNewOrder.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;

            //try-catch-finally
            try
            {
               //Open Connection
               conn.Open();

               //Run the stored procedure
               cmdNewOrder.ExecuteNonQuery();

               //Display the order number
               this.orderID = (int)cmdNewOrder.Parameters["@RC"].Value;
               MessageBox.Show("Order Number " + this.orderID + " has been submitted.");
            }
            catch
            {
               //A simple catch
               MessageBox.Show("Order could not be placed");
            }
            finally
            {
               conn.Close();
            }
         }
      }

      //Verify that order data is ready.
      private bool isPlaceOrderReady()
      {
         //Verify that CustomerID is present.
         if (txtCustomerID.Text == "")
         {
            MessageBox.Show("Create customer account before placing order");
            return false;
         }
         //verify that amoount isn't 0
         else if (numOrderAmount.Value < 1) 
         {
            MessageBox.Show("Specify an order amount");
            return false;
         }
         else
         {
            //submit order
            return true;
         }
      }

      //Clear values from controls
      private void ClearForm()
      {
         txtCustomerName.Clear();
         txtCustomerID.Clear();
         dtpOrderDate.Value = DateTime.Now;
         numOrderAmount.Value = 0;
         this.parsedCustomerID = 0;
      }

      private void btnAddAnotherAccount_Click(object sender, EventArgs e)
      {
         this.ClearForm();
      }

      private void btnAddFinish_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
