using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane("Boieng-777", 100, 90, 800, 10000000, DateTime.Parse("5/1/2008 8:30:52 AM", System.Globalization.CultureInfo.InvariantCulture), 17, 400);
            plane.Information(); Console.WriteLine();
            Car car = new Car("BMW-M3", 50, 50, 300, 30000, DateTime.Parse("5/1/2014 16:45:30 PM", System.Globalization.CultureInfo.InvariantCulture));
            car.Information(); Console.WriteLine();
            Ship ship = new Ship("Supreme", 30, 20, 90, 1000000, DateTime.Parse("5/1/2015 8:00:01 AM", System.Globalization.CultureInfo.InvariantCulture), 300, "Shanghai");
            ship.Information();
            Console.ReadKey();
        }
    }
}
