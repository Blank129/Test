using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            List<CityTime> cityTimes = new List<CityTime>
            {
            new CityTime { City = "Chicago", Time = new TimeSpan(9, 00, 00) },
            new CityTime { City = "Phoenix", Time = new TimeSpan(9, 00, 03) },
            new CityTime { City = "Houston", Time = new TimeSpan(9, 00, 13) },
            new CityTime { City = "Chicago", Time = new TimeSpan(9, 00, 59) },
            new CityTime { City = "Houston", Time = new TimeSpan(9, 01, 10) },
            new CityTime { City = "Seattle", Time = new TimeSpan(9, 10, 11) },
            new CityTime { City = "Seattle", Time = new TimeSpan(9, 10, 25) },
            new CityTime { City = "Phoenix", Time = new TimeSpan(9, 14, 25) },
            new CityTime { City = "Chicago", Time = new TimeSpan(9, 19, 32) },
            new CityTime { City = "Chicago", Time = new TimeSpan(9, 19, 46) },
            new CityTime { City = "Chicago", Time = new TimeSpan(9, 21, 05) },
            new CityTime { City = "Phoenix", Time = new TimeSpan(9, 19, 46) },
            new CityTime { City = "Chicago", Time = new TimeSpan(9, 21, 5) },
            new CityTime { City = "Phoenix", Time = new TimeSpan(9, 37, 44) }
            };

            var sortedTimes = cityTimes.OrderBy(ct => ct.Time).ToList();         
            var sortedCity = cityTimes.OrderBy(ct => ct.City).ToList();
            var sortedCityAndTimes = cityTimes.OrderBy(ct => ct.City).OrderBy(ct=> ct.Time).ToList();

            Console.WriteLine("Sorted by time:");
            foreach (var ct in sortedTimes)
            {
                Console.WriteLine($"{ct.City} {ct.Time}");
            }

            Console.WriteLine();

            Console.WriteLine("Sorted by location (not stable):");
            foreach (var ct in sortedCity)
            {
                Console.WriteLine($"{ct.City} {ct.Time}");
            }

            Console.WriteLine();

            Console.WriteLine("Sorted by location (not stable):");
            foreach (var ct in sortedCityAndTimes)
            {
                Console.WriteLine($"{ct.City} {ct.Time}");
            }


            //4.
            string filePath = "C:/Users/V/Downloads/Test.txt"; 
            FileTest counter = new FileTest(filePath);
            counter.DisplayWordFrequencies();
            Console.ReadLine();
        }
        




    }
}
