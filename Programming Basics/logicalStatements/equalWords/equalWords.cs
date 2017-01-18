using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalWords
{
    class equalWords
    {
        static void Main(string[] args)
        {
            string firstword = Console.ReadLine();
            string secondword = Console.ReadLine();

            firstword = firstword.ToLower();
            secondword =secondword.ToLower();
            if (firstword == secondword)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
