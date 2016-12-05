using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Test";
            File.WriteAllText(@"C:\Test\test\test.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("www.microsoft.com");
            File.WriteAllText(@"C:\Test\test\test2.txt", reply);

            Console.WriteLine(reply);
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
