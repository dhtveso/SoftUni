using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BasicQueueOperations
{
    public class BasicQueueOperations
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var pushedElement = input[0];
            var removedElement = input[1];
            var searchingNumber = input[2];
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>(numbers);

            if (pushedElement == removedElement)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < removedElement; i++)
                {
                    queue.Dequeue();
                }

                if (queue.Contains(searchingNumber))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}