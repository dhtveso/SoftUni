﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = (Console.ReadLine());
            string lastname = (Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string town = (Console.ReadLine());
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstname, lastname, age, town);
        }
    }
}
