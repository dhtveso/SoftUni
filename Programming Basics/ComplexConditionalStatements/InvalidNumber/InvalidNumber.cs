using System;

namespace InvalidNumber
{
    public class InvalidNumber
    {
        public static void Main()
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
