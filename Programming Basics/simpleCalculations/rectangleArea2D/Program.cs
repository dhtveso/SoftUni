using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleArea2D
{
    class Program
    {
        static void Main(string[] args)
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
