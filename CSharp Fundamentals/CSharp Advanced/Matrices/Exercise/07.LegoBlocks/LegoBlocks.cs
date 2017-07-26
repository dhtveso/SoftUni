using System;
using System.Linq;

namespace _07.LegoBlocks
{
    public class LegoBlocks
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            int[][] firstMatrix = new int[input][];
            int[][] secondMatrix = new int[input][];
            int[][] result = new int[input][];

            for (int row = 0; row < input; row++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                firstMatrix[row] = line;
            }

            for (int row = 0; row < input; row++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                secondMatrix[row] = line;
            }

            var count = 1;
            var sumOfCell = 0;

            for (int row = 0; row < firstMatrix.Length; row++)
            {
                sumOfCell += firstMatrix[row].Length;
            }

            for (int row = 0; row < secondMatrix.Length; row++)
            {
                sumOfCell += secondMatrix[row].Length;
            }

            for (int i = 0; i < input - 1; i++)
            {
                int[] sumOfLenght = new int[firstMatrix[i].Length + secondMatrix[i].Length];
                result[i] = sumOfLenght;

                if (firstMatrix[i + count].Length + secondMatrix[i + count].Length == firstMatrix[i].Length + secondMatrix[i].Length)
                {
                    if (i == input - 2)
                    {
                        for (int j = 0; j < input; j++)
                        {
                            Console.Write($"[{string.Join(", ", firstMatrix[j])}");
                            Console.Write($", {string.Join(", ", secondMatrix[j].Reverse())}]");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    if (i == input - 2)
                    {
                        Console.WriteLine($"The total number of cells is: {sumOfCell}");
                    }
                }
            }
        }
    }
}