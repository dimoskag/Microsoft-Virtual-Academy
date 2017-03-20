using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetBasics
{
   class AddParametersQuery
   {
      /// <summary>
      /// Get data with a where clause
      /// </summary>
      /// <param name="sqlquery">Select * query from</param>
      /// <param name="clause">Where clause</param>
      /// <returns></returns>
      public async Task GetQueryWithParam(string sqlquery, string clause)
      {
         using (SqlConnection conn = new SqlConnection("Data Source=local;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
         {
            //Pass the connection to a command object
            using (SqlCommand cmd = new SqlCommand(sqlquery, conn))
            {
               try
               {
                  //Open the connection to a command object
                  await conn.OpenAsync();
                  
                  //Define Parameter
                  SqlParameter param = new SqlParameter();
                  param.ParameterName = "@clause";
                  param.Value = clause;

                  //Add the parameter to the command
                  cmd.Parameters.Add(param);

                  //Timeout command
                  cmd.CommandTimeout = 100000;

                  //Get the data Stream
                  using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                  {
                     //Print the query results for each record
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
