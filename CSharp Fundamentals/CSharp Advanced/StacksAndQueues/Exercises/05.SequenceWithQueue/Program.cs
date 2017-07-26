using System;
using System.Collections.Generic;

namespace _05.SequenceWithQueue
{
    public class Program
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            queue.Enqueue(number);
            var result = new Queue<long>();

            if (number == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 1; i <= 50; i++)
                {
                    queue.Enqueue(queue.Peek() + 1);
                    queue.Enqueue((2 * queue.Peek()) + 1);
                    queue.Enqueue(queue.Peek() + 2);
                    Console.Write(queue.Dequeue() + " ");
                }
            }
        }
    }
}