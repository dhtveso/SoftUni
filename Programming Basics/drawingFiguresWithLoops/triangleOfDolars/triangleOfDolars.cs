using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleOfDolars
{
    class triangleOfDolars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int cow = 0; cow <= row; cow++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
