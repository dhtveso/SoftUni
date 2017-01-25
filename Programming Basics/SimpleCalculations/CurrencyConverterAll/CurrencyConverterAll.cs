using System;

namespace CurrencyConverterAll
{
    public class CurrencyConverterAll
    {
        public static void Main()
        {
            double BGN = 1.0d;
            double USD;
            double EUR;
            double GBP;
            double result;

            EUR = BGN * 1.95583d;
            USD = BGN * 1.79549d;
            GBP = BGN * 2.53405d;

            double Value = double.Parse(Console.ReadLine());
            string Second = Console.ReadLine();
            string Third = Console.ReadLine();

            if (Second == "BGN")
            {
                if (Third == "USD")
                {
                    result = Value / USD;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (Third == "EUR")
                {
                    result = Value / EUR;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (Third == "GBP")
                {
                    result = Value / GBP;
                    Console.WriteLine("{0:F2}", result);
                }
            }
            if (Second == "USD")
            {
                if (Third == "BGN")
                {
                    result = Value * USD / BGN;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (Third == "EUR")
                {
                    result = USD / EUR * Value;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (Third == "GBP")
                {
                    result = USD / GBP * Value;
                    Console.WriteLine("{0:F2}", result);
                }
            }
            if (Second == "EUR")
            {
                if (Third == "BGN")
                {
                    result = EUR / BGN * Value;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (Third == "USD")
                {
                    result = EUR / USD * Value;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (Third == "GBP")
                {
                    result = EUR / GBP * Value;
                    Console.WriteLine("{0:F2}", result);
                }
            }
            if (Second == "GBP")
            {
                if (Third == "BGN")
                {
                    result = GBP / BGN * Value;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (Third == "USD")
                {
                    result = GBP / USD * Value;
                    Console.WriteLine("{0:F2}", result);
                }
                else if (Third == "EUR")
                {
                    result = GBP / EUR * Value;
                    Console.WriteLine("{0:F2}", result);
                }
            }
        }
    }
}




