using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            double degrees = (180 / Math.PI) * radians;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
