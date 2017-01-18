using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triplesOfLatinLetters
{
    class triplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char first = 'a'; first < number + 'a'; first++)
            {
                for (char second = 'a'; second < number + 'a'; second++)
                {
                    for (char third = 'a'; third < number + 'a'; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
