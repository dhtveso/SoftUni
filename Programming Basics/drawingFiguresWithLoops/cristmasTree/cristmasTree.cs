using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cristmasTree
{
    class cristmasTree
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(new string(' ', n - i) + new string('*', i) + " | " + new string('*', i));
                Console.WriteLine();
            }
        }
    }
}
