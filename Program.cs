using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { Cname = "Car1", Make = "BMW", Model = "dd", Year = 1999 },
                new Car() { Cname = "Car2", Make = "Audi", Model = "ioiuy", Year = 1888 },
                new Car() { Cname = "car3", Make="Toyoto", Model = "5445", Year = 2000 },
                new Car() { Cname = "car4", Make = "Ford", Model = "4545", Year = 1799 },

            };
            var cars = myCars.Where(x => x.Cname == "Car1").ToList();
            foreach (var checkcar in cars)
            {
                Console.WriteLine( checkcar.Cname);
            }
            
        }
        
    }

    
}
class Car
{
    public string Cname{ get; set; }
    public string Model{ get; set; }
    public string Make{ get; set; }
    public int Year{ get; set; }
}
