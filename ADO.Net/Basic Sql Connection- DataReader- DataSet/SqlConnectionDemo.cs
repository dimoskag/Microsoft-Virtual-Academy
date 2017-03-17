using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetBasics
{
   class SqlConnectionDemo
   {
      /// <summary>
      /// Demonstrates how to work with SqlConnection objects
      /// </summary>
      public async Task GetSingleValueMethod(string sqlquery)
      {
         //1. Instantiate the connection
         using (SqlConnection conn = new SqlConnection("Data Source=local;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
         {
            //3. Pass the connection to a command object
            using (SqlCommand cmd = new SqlCommand(sqlquery, conn))
            {
               try
               {
                  //2. Open the connection & timeout command
                  await conn.OpenAsync();
                  cmd.CommandTimeout = 100000;

                  //3. Use the connection
                  // Get query results
                  using (var rdr = await cmd.ExecuteReaderAsync())
                  {
                     //print the query results for each record
                     while (await rdr.ReadAsync())
                     {
                        Console.WriteLine(rdr[0]);
                     }
                  }
               }
               catch (SqlException ex)
               {
                  throw ex;
               }
            }
         }
      }

      public async Task GetDatasetMethod(string sqlquery)
      {
         using (SqlConnection conn = new SqlConnection("Data Source=local;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
         {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, conn))
            {
               try
               {
                  await conn.OpenAsync();

                  using (DataSet table = new DataSet())
                  {
                     adapter.Fill(table);

                     foreach (DataTable dt in table.Tables)
                     {
                        foreach (DataRow row in dt.Rows)
                        {
                           Console.WriteLine("{0} , {1} , {2}", row[0], row[1], row[2]);
                        }                       
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
