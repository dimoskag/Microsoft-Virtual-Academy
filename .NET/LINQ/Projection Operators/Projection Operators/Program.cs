using System;
using System.Linq;

namespace Projection_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SelectSimple1();

            Console.ReadLine();
        }

        public void SelectSimple1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numPlusOne = from n in numbers
                             select n + 1;

            Console.WriteLine("Numbers + 1:");
            foreach (var i in numPlusOne)
            {
                Console.WriteLine(i);
            }
        }
    }
}
