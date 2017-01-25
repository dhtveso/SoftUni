using System;

namespace MetricConverter
{
    public class MetricConverter
    {
        public static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var output = Console.ReadLine();

            var meters = 0d;

            if (input == "mm")
            {
                meters = lenght / 1000;
            }
            else if (input == "cm")
            {
                meters = lenght / 100;
            }
            else if (input == "mi")
            {
                meters = lenght / 0.000621371192;
            }
            else if (input == "in")
            {
                meters = lenght / 39.3700787;
            }
            else if (input == "km")
            {
                meters = lenght / 0.001;
            }
            else if (input == "ft")
            {
                meters = lenght / 3.2808399;
            }
            else if (input == "yd")
            {
                meters = lenght / 1.0936133;
            }
            else if (input == "m")
            {
                meters = lenght;
            }

            var outputlenght = 0d;

            if (output == "mm")
            {
                outputlenght = meters * 1000;
            }
            else if (output == "cm")
            {
                outputlenght = meters * 100;
            }
            else if (output == "mi")
            {
                outputlenght = meters * 0.000621371192;
            }
            else if (output == "in")
            {
                outputlenght = meters * 39.3700787;
            }
            else if (output == "km")
            {
                outputlenght = meters * 0.001;
            }
            else if (output == "ft")
            {
                outputlenght = meters * 3.2808399;
            }
            else if (output == "yd")
            {
                outputlenght = meters * 1.0936133;
            }
            else if (output == "m")
            {
                outputlenght = meters;
            }

            Console.WriteLine(outputlenght + " " + output);
        }
    }
}

