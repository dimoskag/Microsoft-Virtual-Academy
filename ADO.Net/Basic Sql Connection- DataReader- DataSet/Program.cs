using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetBasics
{
   class Program
   {
      static void Main(string[] args)
      {
         Task.Run(async () =>
         {
            SqlConnectionDemo demo = new SqlConnectionDemo();
            await demo.GetSingleValueMethod("select * from Customers");
         }).GetAwaiter().GetResult();

         Task.Run(async () =>
         {
            SqlConnectionDemo demo = new SqlConnectionDemo();
            await demo.GetDatasetMethod("select * from Customers");
         }).GetAwaiter().GetResult();

         Console.ReadKey();
      }
   }
}
