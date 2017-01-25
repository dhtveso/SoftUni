using System;

namespace NumbersTo100
{
    public class NumbersTo100
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int firstnumber = number / 10;
            int secondnumber = number % 10;
            int from10to20 = number;
            string secword = "";
            string firstword = "";
            string fromTenToword = "";


            switch (secondnumber)
            {
                case 0:
                    secword = "zero";
                    break;
                case 1:
                    secword = "one";
                    break;
                case 2:
                    secword = "two";
                    break;
                case 3:
                    secword = "three";
                    break;
                case 4:
                    secword = "four";
                    break;
                case 5:
                    secword = "five";
                    break;
                case 6:
                    secword = "six";
                    break;
                case 7:
                    secword = "seven";
                    break;
                case 8:
                    secword = "eight";
                    break;
                case 9:
                    secword = "nine";
                    break;
                default:
                    break;
            }
            switch (firstnumber)
            {
                case 2:
                    firstword = "twenty";
                    break;
                case 3:
                    firstword = "thirty";
                    break;
                case 4:
                    firstword = "fourty";
                    break;
                case 5:
                    firstword = "fifty";
                    break;
                case 6:
                    firstword = "sixty";
                    break;
                case 7:
                    firstword = "seventy";
                    break;
                case 8:
                    firstword = "eighty";
                    break;
                case 9:
                    firstword = "ninety";
                    break;
                default:
                    break;
            }
            switch (from10to20)
            {
                case 10:
                    fromTenToword = "ten";
                    break;
                case 11:
                    fromTenToword = "eleven";
                    break;
                case 12:
                    fromTenToword = "twelve";
                    break;
                case 13:
                    fromTenToword = "thirteen";
                    break;
                case 14:
                    fromTenToword = "fourteen";
                    break;
                case 15:
                    fromTenToword = "fifteen";
                    break;
                case 16:
                    fromTenToword = "sixteen";
                    break;
                case 17:
                    fromTenToword = "seventeen";
                    break;
                case 18:
                    fromTenToword = "eighteen";
                    break;
                case 19:
                    fromTenToword = "nineteen";
                    break;
                default:
                    break;
            }
            if (number < 10 && number >= 0)
            {
                Console.WriteLine(secword);
            }
            else if (number >= 10 && number < 20)
            {
                Console.WriteLine(fromTenToword);
            }
            else if (number == firstnumber * 10 && number < 100)
            {
                Console.WriteLine(firstword);
            }
            else if (number == firstnumber * 10 + secondnumber && number < 100 && number > 0)
            {
                Console.WriteLine(firstword + " " + secword);
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (number < 0)
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
