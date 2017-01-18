using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refactorVolumeOfPyramid
{
    class refactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            var pyramidVolume = 0d;

            pyramidVolume = (length * width * height) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", pyramidVolume);

        }
    }
}
