using System;

namespace FruitShop
{
    public class FruitShop
    {
        public static void Main()
        {
            var fruit = Console.ReadLine();
            var Day = Console.ReadLine();
            var number = double.Parse(Console.ReadLine());
            var price = 0d;

            if (Day == "Monday" || Day == "Tuesday" || Day == "Wednesday" || Day == "Thursday" || Day == "Friday")
            {
                if (fruit == "banana")
                {
                    price = number * 2.50;
                    Console.WriteLine(price);
                }
                else if (fruit == "apple")
                {
                    price = number * 1.20;
                    Console.WriteLine(price);
                }
                else if (fruit == "orange")
                {
                    price = number * 0.85;
                    Console.WriteLine(price);
                }
                else if (fruit == "grapefruit")
                {
                    price = number * 1.45;
                    Console.WriteLine(price);
                }
                else if (fruit == "kiwi")
                {
                    price = number * 2.70;
                    Console.WriteLine(price);
                }
                else if (fruit == "pineapple")
                {
                    price = number * 5.50;
                    Console.WriteLine(price);
                }
                else if (fruit == "grapes")
                {
                    price = number * 3.85;
                    Console.WriteLine(price);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (Day == "Sunday" || Day == "Saturday")
            {
                if (fruit == "banana")
                {
                    price = number * 2.70;
                    Console.WriteLine(price);
                }
                else if (fruit == "apple")
                {
                    price = number * 1.25;
                    Console.WriteLine(price);
                }
                else if (fruit == "orange")
                {
                    price = number * 0.90;
                    Console.WriteLine(price);
                }
                else if (fruit == "grapefruit")
                {
                    price = number * 1.60;
                    Console.WriteLine(price);
                }
                else if (fruit == "kiwi")
                {
                    price = number * 3.00;
                    Console.WriteLine(price);
                }
                else if (fruit == "pineapple")
                {
                    price = number * 5.60;
                    Console.WriteLine(price);
                }
                else if (fruit == "grapes")
                {
                    price = number * 4.20;
                    Console.WriteLine(price);
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
