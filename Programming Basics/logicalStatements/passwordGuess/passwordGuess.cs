using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordGuess
{
    class passwordGuess
    {
        static void Main(string[] args)
        {
            string PasswordText = Console.ReadLine();
            string phrase = "s3cr3t!P@ssw0rd";
            if (PasswordText == phrase)
            {
                Console.WriteLine("welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
