using System;

namespace NumberEndingIn7
{
    public class NumberEndingIn7
    {
        public static void Main()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 10 ==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
