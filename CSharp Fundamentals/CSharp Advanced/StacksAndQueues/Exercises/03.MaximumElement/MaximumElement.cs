using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    public class MaximumElement
    {
        public static void Main()
        {
            var numberCount = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxNumber = new Stack<int>();
            var maxValue = int.MinValue;

            for (int i = 0; i < numberCount; i++)
            {
                var inputInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var opeartion = inputInfo[0];
                if (opeartion == 1)
                {
                    stack.Push(inputInfo[1]);
                    if (maxValue < inputInfo[1])
                    {
                        maxValue = inputInfo[1];
                        maxNumber.Push(maxValue);
                    }
                }
                else if (opeartion == 2)
                {
                    if (stack.Pop() == maxValue)
                    {
                        maxNumber.Pop();
                        if (maxNumber.Count != 0)
                        {
                            maxValue = maxNumber.Peek();
                        }
                        else
                        {
                            maxValue = int.MinValue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(maxValue);
                }
            }
        }
    }
}