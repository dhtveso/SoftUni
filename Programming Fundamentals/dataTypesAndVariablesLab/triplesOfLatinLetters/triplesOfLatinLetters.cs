using System;

namespace TriplesOfLatinLetters
{
    public class TriplesOfLatinLetters
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char first = 'a'; first < number + 'a'; first++)
            {
                for (char second = 'a'; second < number + 'a'; second++)
                {
                    for (char third = 'a'; third < number + 'a'; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
