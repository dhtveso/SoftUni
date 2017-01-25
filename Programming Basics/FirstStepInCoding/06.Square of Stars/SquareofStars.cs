using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_of_Stars
{
    class SquareofStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.WriteLine(new string('*', n));
                    continue;
                }
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 || j == n)
                    {
                        Console.Write("*");
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
