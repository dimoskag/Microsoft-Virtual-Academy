using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "My \"so-called\" life";
            myString = "What if I need a \nnew line?";
            myString = "Go to your c:\\ drive";
            myString = @"Go to your c:\ drive";

            myString = string.Format("{0}={1}", "First", "Second");
            myString = string.Format("Price: {0:C}", 123.45);
            myString = string.Format("{0:N}", 123456789);
            myString = string.Format("Percentage: {0:P}", .123);
            myString = string.Format("Phone: {0:(###) ###-####}", 1234567890);

            myString = " That summer we took threes across the board  ";
            //starts at the sixth char and counts 14
            myString = myString.Substring(6, 14);
            myString = myString.ToUpper();
            myString = myString.Replace(" ", "--");
            myString = myString.Remove(6, 14);
            myString = string.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            
            //more efficient
            StringBuilder my2String = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                my2String.Append("--");
                my2String.Append(i);
            }

            Console.WriteLine(myString);
            Console.WriteLine(my2String);
            Console.ReadLine();
        }
    }
}
