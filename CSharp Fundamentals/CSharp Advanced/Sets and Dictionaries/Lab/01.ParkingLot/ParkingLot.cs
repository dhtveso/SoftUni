using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.ParkingLot
{
    public class ParkingLot
    {
        public static void Main()
        {
            var parking = new SortedSet<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                var inputParams = Regex.Split(input, ", ").ToArray();
                var IO = inputParams[0];
                var car = inputParams[1];

                if (IO == "IN")
                {
                    parking.Add(car);
                }
                else if (parking.Contains(car))
                {
                    parking.Remove(car);
                }
                input = Console.ReadLine();
            }

            if (parking.Count != 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}