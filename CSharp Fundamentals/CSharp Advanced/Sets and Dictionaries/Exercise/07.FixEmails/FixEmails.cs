using System;
using System.Collections.Generic;

namespace _07.FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            var mailBook = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string email;

            while (!name.Equals("stop"))
            {
                email = Console.ReadLine();
                var lastTwo = email.Substring(email.Length - 2, 2).ToLower();

                if (lastTwo != "uk" && lastTwo != "us")
                {
                    if (!mailBook.ContainsKey(name))
                    {
                        mailBook.Add(name, email);
                    }
                    else { mailBook[name] = email; }
                }
                name = Console.ReadLine();
            }

            foreach (var pair in mailBook)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
