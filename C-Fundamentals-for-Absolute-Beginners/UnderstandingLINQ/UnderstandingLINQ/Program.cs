using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() {VIN="A1", Make="BMW", Model="550i", StickerPrice=55000, Year=2009},
                new Car() {VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010 },
                new Car() {VIN="C3", Make="BMW", Model="745li", StickerPrice=75000, Year=2008 },
                new Car() {VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008 },
                new Car() {VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010 }
            };

            //LINQ query
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;

            //LINQ method
            var bmws2 = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;

            var orderedCars2 = myCars.OrderByDescending(p => p.Year);

            var firstBMW = myCars.OrderByDescending(x => x.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);

            Console.WriteLine(myCars.TrueForAll(x => x.Year > 2012));

            myCars.ForEach(x => x.StickerPrice -= 3000);
            myCars.ForEach(x => Console.WriteLine("{0} {1:C}", x.VIN, x.StickerPrice));

            Console.WriteLine(myCars.Exists(x => x.Model == "745l1"));

            Console.WriteLine(myCars.Sum(x => x.StickerPrice));

            Console.WriteLine(myCars.GetType());
            Console.WriteLine(orderedCars2.GetType());
            Console.WriteLine(bmws2.GetType());

            var newCars = from car in myCars
                          where car.Make == "BMW"
                          && car.Year == 2010
                          select new { car.Make, car.Model };

            Console.WriteLine(newCars.GetType());

            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            foreach (var car in bmws2)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }

            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model);
            }

            foreach (var car in orderedCars2)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
