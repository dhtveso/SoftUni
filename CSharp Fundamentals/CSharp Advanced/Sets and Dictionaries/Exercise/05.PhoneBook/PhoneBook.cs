using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PhoneBook
{
    public class PhoneBook
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();

            while (input != "search")
            {
                var args = input.Split('-').ToArray();
                var person = args[0];
                var number = args[1];

                if (phonebook.ContainsKey(person))
                {
                    phonebook[person] = number;
                }
                else
                {
                    phonebook[person] = number;
                }
                input = Console.ReadLine();
            }

            var searchingName = Console.ReadLine();

            while (searchingName != "stop")
            {
                if (phonebook.ContainsKey(searchingName))
                {
                    Console.WriteLine($"{searchingName} -> {phonebook[searchingName]}");
                }
                else
                {
                    Console.WriteLine($"Contact {searchingName} does not exist.");
                }
                searchingName = Console.ReadLine();
            }
        }
    }
}
