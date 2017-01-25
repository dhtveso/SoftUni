using System;

namespace PasswordGuess
{
    public class PasswordGuess
    {
        public static void Main()
        {
            string PasswordText = Console.ReadLine();
            string phrase = "s3cr3t!P@ssw0rd";

            if (PasswordText == phrase)
            {
                Console.WriteLine("welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
