using System;

namespace EqualWords
{
    public class EqualWords
    {
        public static void Main()
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
