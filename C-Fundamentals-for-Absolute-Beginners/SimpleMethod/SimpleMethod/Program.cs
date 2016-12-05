using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.WriteLine("Please enter your name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your city:");
            string city = Console.ReadLine();

            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));
            Console.WriteLine();
            DisplayResult(ReverseString((firstName) + " " + ReverseString(lastName) + ReverseString(city)));
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
        }
        public static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write(string.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedCity));
        }

        public static void DisplayResult(string message)
        {
            Console.Write(message);
        }

    }
}
