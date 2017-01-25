using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    public class TriangleArea
    {
        public static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = lenght * height / 2;

            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
