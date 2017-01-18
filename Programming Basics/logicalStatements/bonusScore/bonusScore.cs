using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusScore
{
    class bonusScore
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var bonus = 0d;
            if (number <= 100)
            {
                bonus = bonus + 5;
            }
            else if (number <= 1000)
            {
                bonus = number * 0.2;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            if (number % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
