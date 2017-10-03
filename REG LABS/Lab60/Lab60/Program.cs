using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab60
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>()
            {
                new Car() { Make = "BMW", Model = "550i", Color = Car.CarColor.Blue, StickerPrice = 55000, Year = 2009 },
                new Car() { Make = "Toyota", Model = "4Runner", Color = Car.CarColor.White, StickerPrice = 35000, Year = 2010 },
                new Car() { Make = "BMW", Model = "745li", Color = Car.CarColor.Black, StickerPrice = 75000, Year = 2008 },
                new Car() { Make = "Ford", Model = "Escape", Color = Car.CarColor.White, StickerPrice = 28000, Year = 2008 },
                new Car() { Make = "BMW", Model = "550i", Color = Car.CarColor.Black, StickerPrice = 57000, Year = 2010 }
            };

            Console.WriteLine(" 2010 BMWs\n");

            var tenBeamers = from c in carList
                             where c.Make == "BMW" && c.Year == 2010
                             select new { c.Make, c.Model, c.Color, c.StickerPrice, c.Year };
            foreach (var car in tenBeamers)
            {
                Console.WriteLine($"{car.Year} {car.Color} {car.Make} {car.Model} - {car.StickerPrice:C}");
            }

            Console.WriteLine("\n Car Year > 2009\n");

            var overNiners = from c in carList
                             where c.Year > 2009
                             select new { c.Make, c.Model, c.Color, c.StickerPrice, c.Year };
            foreach (var car in overNiners)
            {
                Console.WriteLine($"{car.Year} {car.Color} {car.Make} {car.Model} - {car.StickerPrice:C}");
            }

            Console.WriteLine("\n Cars Ordered Descending\n");

            var descendingCars = from c in carList
                                 orderby c.Year descending
                                 select c;
            foreach (var car in descendingCars)
            {
                Console.WriteLine($"{car.Year} {car.Color} {car.Make} {car.Model} - {car.StickerPrice:C}");
            }
        }
    }
}
