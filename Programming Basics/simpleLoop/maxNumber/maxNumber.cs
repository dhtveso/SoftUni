using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxNumber
{
    class maxNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var numberCount = int.Parse(Console.ReadLine());
                if (numberCount > max)
                {
                    max = numberCount;
                }
            }
            Console.WriteLine(max);
        }
    }
}
