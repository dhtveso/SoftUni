using System;
using System.Linq;

namespace _03.GroupNumbers
{
    public class GroupNumbers
    {
        public static void Main()
        {
            var inputNumber = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var zeroResidue = inputNumber.Where(x => Math.Abs(x) % 3 == 0).ToArray();
            var oneResidue = inputNumber.Where(x => Math.Abs(x) % 3 == 1).ToArray();
            var twoResidue = inputNumber.Where(x => Math.Abs(x) % 3 == 2).ToArray();

            Console.WriteLine(string.Join(" ", zeroResidue));
            Console.WriteLine(string.Join(" ", oneResidue));
            Console.WriteLine(string.Join(" ", twoResidue));
        }
    }
}
