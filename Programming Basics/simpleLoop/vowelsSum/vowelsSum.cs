using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelsSum
{
    class vowelsSum
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var currentLetter = text[i];
                if (currentLetter == 'a')
                {
                    sum += 1;
                }
                else if (currentLetter == 'e')
                {
                    sum += 2;
                }
                else if (currentLetter == 'i')
                {
                    sum += 3;
                }
                else if (currentLetter == 'o')
                {
                    sum += 4;
                }
                else if (currentLetter == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
