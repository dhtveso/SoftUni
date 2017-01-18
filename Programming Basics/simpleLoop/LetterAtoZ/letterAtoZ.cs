using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letterAtoZ
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
