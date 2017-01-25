using System;

namespace SmallShop
{
    public class SmallShop
    {
        public static void Main()
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = decimal.Parse(Console.ReadLine());
            var totalprice = 0m;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    totalprice = quantity * 0.50m;
                }
                else if (product == "water")
                {
                    totalprice = quantity * 0.80m;
                }
                else if (product == "beer")
                {
                    totalprice = quantity * 1.20m;
                }
                else if (product == "sweets")
                {
                    totalprice = quantity * 1.45m;
                }
                else if (product == "peanuts")
                {
                    totalprice = quantity * 1.60m;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    totalprice = quantity * 0.40m;
                }
                else if (product == "water")
                {
                    totalprice = quantity * 0.70m;
                }
                else if (product == "beer")
                {
                    totalprice = quantity * 1.15m;
                }
                else if (product == "sweets")
                {
                    totalprice = quantity * 1.30m;
                }
                else if (product == "peanuts")
                {
                    totalprice = quantity * 1.50m;
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    totalprice = quantity * 0.45m;
                }
                else if (product == "water")
                {
                    totalprice = quantity * 0.70m;
                }
                else if (product == "beer")
                {
                    totalprice = quantity * 1.10m;
                }
                else if (product == "sweets")
                {
                    totalprice = quantity * 1.35m;
                }
                else if (product == "peanuts")
                {
                    totalprice = quantity * 1.55m;
                }
            }

            Console.WriteLine(totalprice);
        }
    }
}
