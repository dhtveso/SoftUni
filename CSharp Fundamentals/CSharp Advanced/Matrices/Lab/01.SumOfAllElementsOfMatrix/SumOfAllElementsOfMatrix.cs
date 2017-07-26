using System;
using System.Linq;

namespace _01.SumOfAllElementsOfMatrix
{
    public class SumOfAllElementsOfMatrix
    {
        public static void Main()
        {
            var rowCow = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = rowCow[0];
            var cows = rowCow[1];
            int[][] matrix = new int[rows][];
            var sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                var matrixLine = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                matrix[i] = matrixLine;
                sum += matrix[i].Sum();
            }

            Console.WriteLine(rows);
            Console.WriteLine(cows);
            Console.WriteLine(sum);
        }
    }
}
