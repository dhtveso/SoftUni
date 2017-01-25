using System;

namespace CircleAreaAndPerimeter
{
    public class CircleAreaAndPerimeter
    {
        public static void Main()
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var Perimeter = 2 * Math.PI * r;

            Console.WriteLine(area);
            Console.WriteLine(Perimeter);
        }
    }
}
