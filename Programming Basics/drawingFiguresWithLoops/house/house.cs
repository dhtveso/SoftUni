﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    class house
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stars = 1;

            if (n % 2 == 0)
            {
                stars = 2;
            }

            var leftrightBlank = (n - stars) / 2;

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                Console.Write(new string('-', leftrightBlank));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', leftrightBlank));



                leftrightBlank--;
                stars = stars + 2;
                Console.WriteLine();
            }

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write("{0}{1}{0}", '|', new string('*', n - 2));
                Console.WriteLine();
            }
        }
    }
}
