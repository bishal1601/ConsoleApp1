using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "apple", "banana" , "orange", "mango", "pineapple" };

            // LINQ query to select names that contain the letter 'k'
            var a = from n in name
                    where n.Length > 5
                    select n;

            // Iterate through the filtered names and print them
            foreach (string item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
