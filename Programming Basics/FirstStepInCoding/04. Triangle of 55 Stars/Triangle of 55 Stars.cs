using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_of_55_Stars
{
    class TriangleOf55Stars
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 10; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
