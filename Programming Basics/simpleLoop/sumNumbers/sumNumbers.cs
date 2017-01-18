using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNumbers
{
    class sumNumbers
    {
        static void Main(string[] args)
        {
            var Num = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < Num; i++)
            {
                var cifri = int.Parse(Console.ReadLine());
                sum += cifri;
            }
            Console.WriteLine(sum);
        }
    }
}
