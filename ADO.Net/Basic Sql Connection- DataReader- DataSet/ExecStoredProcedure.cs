using System;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetBasics
{
   class ExecStoredProcedure
   {
      public async Task RunStoredProcedure(string spName)
      {
         using (SqlConnection conn = new SqlConnection("Data Source=local;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
         {
            //Pass the connection to a command object
            using (SqlCommand cmd = new SqlCommand(spName, conn))
            {
               try
               {
                  //Open the connection to a command object
                  await conn.OpenAsync();

                  //Set the command so that it knows it is executing a stored procedure
                  cmd.CommandType = CommandType.StoredProcedure;

                  //Timeout the command
                  cmd.CommandTimeout = 100000;

                  //Get data from sp
                  using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                  {
                     //Print the sp results
                     while (await reader.ReadAsync())
                     {
                        Console.WriteLine("{0} | {1}", reader[0], reader[1]);
                     }
                  }
               }
               catch (Exception ex)
               {
                  throw ex;
               }
            }
         }
      }   

      public async Task RunStoredProcedureWithParam(string spname, string custId)
      {
         using (SqlConnection conn = new SqlConnection("Data Source=local;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
         {
            //Pass the connection to a command object
            using (SqlCommand cmd = new SqlCommand(spname, conn))
            {
               try
               {
                  //Open the connection to a command object
                  await conn.OpenAsync();

                  //Set the command so that it knows it is executing a stored procedure
                  cmd.CommandType = CommandType.StoredProcedure;

                  //Add a parameter for the command to pass to the sp
                  cmd.Parameters.Add(new SqlParameter("@CustomerID", custId));

                  //Timeout command
                  cmd.CommandTimeout = 100000;

                  //Get data
                  using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                  {
                     //Print the results
                     while (await reader.ReadAsync())
                     {
                        Console.WriteLine("{0} | {1}", reader[0], reader[1]);
                     }
                  }

               }
               catch (Exception ex)
               {
                  throw ex;
               }
            }
         }
      }
   }
}
