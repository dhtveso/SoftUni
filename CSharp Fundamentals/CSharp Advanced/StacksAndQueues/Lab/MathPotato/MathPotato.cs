using System;
using System.Collections.Generic;

namespace MathPotato
{
    public class MathPotato
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var queue = new Queue<string>(input.Split(' '));
            var number = int.Parse(Console.ReadLine());
            int cycle = 1;

            while (queue.Count > 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    string reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }

                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine("Prime {0}", queue.Peek());
                }
                else
                {
                    Console.WriteLine("Removed {0}", queue.Dequeue());
                }
                cycle++;
            }

            Console.WriteLine("Last is {0}", queue.Dequeue());
        }

        public static class PrimeTool
        {
            public static bool IsPrime(int candidate)
            {
                if ((candidate & 1) == 0)
                {
                    if (candidate == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                for (int i = 3; (i * i) <= candidate; i += 2)
                {
                    if ((candidate % i) == 0)
                    {
                        return false;
                    }
                }

                return candidate != 1;
            }
        }
    }
}