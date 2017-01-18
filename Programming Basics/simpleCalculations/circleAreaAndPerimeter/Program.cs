using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var Perimeter = 2 * Math.PI * r;
            Console.WriteLine(area);
            Console.WriteLine(Perimeter);
        }
    }
}
