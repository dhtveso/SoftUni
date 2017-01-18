using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumSeconds
{
    class sumSeconds
    {
        static void Main(string[] args)
        {
            var firsttime = int.Parse(Console.ReadLine());
            var secondtime = int.Parse(Console.ReadLine());
            var thirdtime = int.Parse(Console.ReadLine());
            var totaltime = firsttime + secondtime + thirdtime;
            var minutes = totaltime / 60;
            var second = totaltime % 60;
            Console.Write(minutes);

            if (second < 10)
            {
                Console.WriteLine(":0" + second);
            }
            else
            {
                Console.WriteLine(":" + second);
            }
        }
    }
}
