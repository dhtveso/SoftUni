using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidNumber
{
    class invalidNumber
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var inrange = (num >= 100 && num <= 200) || (num == 0);

            if (!inrange)
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
