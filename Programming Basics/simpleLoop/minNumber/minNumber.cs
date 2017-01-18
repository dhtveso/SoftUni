using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minNumber
{
    class minNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var min = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var numberCount = int.Parse(Console.ReadLine());
                if (numberCount < min)
                {
                    min = numberCount;
                }
            }
            Console.WriteLine(min);
        }
    }
}
