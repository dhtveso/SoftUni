using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareOfStars
{
    class squareOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int cow = 0; cow < n; cow++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
