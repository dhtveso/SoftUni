using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8d + 32;
            Console.WriteLine("Temperature in Fahrenheit is: {0:F2}", fahrenheit);
        }
    }
}
