using System;
using System.Collections.Generic;

namespace _02.SoftUniParty
{
    public class SoftUniParty
    {
        public static void Main()
        {
            var reservations = new SortedSet<string>();
            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                reservations.Add(input);
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                if (reservations.Contains(input))
                {
                    reservations.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(reservations.Count);

            foreach (var reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
        }
    }
}