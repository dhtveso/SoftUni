using System;

namespace CircleArea
{
    public class CircleArea
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double areaOfCircle = Math.PI * radius * radius;

            Console.WriteLine("{0:F12}",areaOfCircle);
        }
    }
}
