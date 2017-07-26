using System;

namespace _04.PascalTriangle
{
    public class PascalTriangle
    {
        public static void Main()
        {
            var inputNumber = long.Parse(Console.ReadLine());
            long[][] matrix = new long[inputNumber][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new long[row + 1];
                matrix[row][0] = 1;
                matrix[row][matrix[row].Length - 1] = 1;

                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    matrix[row][col + 1] = matrix[row - 1][col + 1] + matrix[row - 1][col];
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
