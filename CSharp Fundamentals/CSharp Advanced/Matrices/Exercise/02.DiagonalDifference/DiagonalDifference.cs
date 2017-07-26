using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            var sizeSquare = int.Parse(Console.ReadLine());
            int[][] matrix = new int[sizeSquare][];
            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                var numbersLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[i] = numbersLine;
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                var currentSumPrimary = 0;
                var currentSumSecondary = 0;

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (row == col)
                    {
                        currentSumPrimary = matrix[row][col];
                        primaryDiagonalSum += currentSumPrimary;
                        currentSumSecondary = matrix[row][matrix.Length - col - 1];
                        secondaryDiagonalSum += currentSumSecondary;
                    }
                }
            }

            Console.WriteLine(Math.Abs(secondaryDiagonalSum - primaryDiagonalSum));
        }
    }
}