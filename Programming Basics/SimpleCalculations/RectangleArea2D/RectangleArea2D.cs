using System;

namespace RectangleArea2D
{
    public class RectangleArea2D
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a = Math.Max(x1, x2) - Math.Min(x1, x2);
            double b = Math.Max(y1, y2) - Math.Min(y1, y2);
            double area = a * b;
            double perimeter = 2 * (a + b);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
