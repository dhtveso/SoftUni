using System;

namespace CelsiusToFahrenheit
{
    public class CelsiusToFahrenheit
    {
        public static void Main()
        {
            var celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8d + 32;
            Console.WriteLine("Temperature in Fahrenheit is: {0:F2}", fahrenheit);
        }
    }
}
