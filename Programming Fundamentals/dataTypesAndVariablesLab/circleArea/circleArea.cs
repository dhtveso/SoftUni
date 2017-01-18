using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleArea
{
    class circleArea
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double areaOfCircle = Math.PI * radius * radius;

            Console.WriteLine("{0:F12}",areaOfCircle);

        }
    }
}
