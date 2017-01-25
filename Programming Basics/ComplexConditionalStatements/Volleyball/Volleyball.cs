using System;

namespace Volleyball
{
    public class Volleyball
    {
        public static void Main()
        {
            var YearType = Console.ReadLine();
            double Holyday = double.Parse(Console.ReadLine());
            double Traveling = double.Parse(Console.ReadLine());
            double WeekendInSofia = 48 - Traveling;

            if (YearType == "leap")
            {
                double playweekend = WeekendInSofia * 0.75;
                double AllPlay = playweekend + Traveling + (Holyday * 2 / 3);
                double leapyear = 0.15 * AllPlay;
                double Sum = AllPlay + leapyear;
                Console.WriteLine("{0}", Math.Floor(Sum));
            }
            else if (YearType == "normal")
            {
                double playweekend = WeekendInSofia * 0.75;
                double AllPlay = playweekend + Traveling + (Holyday * 2 / 3);
                Console.WriteLine("{0}", Math.Floor(AllPlay));
            }
        }
    }
}
