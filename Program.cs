using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,avg=0,count=0;
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var sums in num)
            {
                count++;
                sum += sums;
                
            }

            if (count > 0)
            {
                avg = sum / count;
            }
           
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            string[] students = { "Student 1", "Student 12", "Student 123", "Student 1234"};
            var Student=from student in students where student.Length > 9 select student;
            foreach (var checkstudent in Student)
            {
                Console.WriteLine(checkstudent.ToString());
                
            }
            List<Car> myCars = new List<Car>()
            {
                new Car() { Cname = "Car1", Make = "BMW", Model = "dd", Year = 1999 },
                new Car() { Cname = "Car2", Make = "Audi", Model = "ioiuy", Year = 1888 },
                new Car() { Cname = "car3", Make="Toyoto", Model = "5445", Year = 2000 },
                new Car() { Cname = "car4", Make = "Ford", Model = "4545", Year = 1799 },

            };
            var cars = myCars.Where(x => x.Cname == "Car1").ToList();
            var cars2= from car in myCars where car.Cname == "Car2" select car; 
            foreach (var checkcar in cars)
            {
                Console.WriteLine( checkcar.Cname);
            }
            foreach (var checkcar in cars2)
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
