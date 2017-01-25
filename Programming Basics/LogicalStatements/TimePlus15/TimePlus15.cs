using System;

namespace TimePlus15
{
    public class TimePlus15
    {
        public static void Main()
        {
            double hour = double.Parse(Console.ReadLine());
            double minute = double.Parse(Console.ReadLine());

            if (hour == 23 && minute >= 45 && minute <= 54)
            {
                var hour1 = (hour + 1) % 24;
                double minute1 = (minute + 15) - 60;
                Console.WriteLine(hour1 + ":0{0}", Math.Floor(minute1));
            }
            else if (hour ==23 && minute >= 55)
            {
                var hour1 = (hour + 1) % 24;
                double minute1 = (minute + 15) - 60;
                Console.WriteLine(hour1 + ":{0}", Math.Floor(minute1));
            }
            else if (minute >= 45 && minute <=54)
            {
                hour++;
                double minute1 = (minute + 15) - 60;
                Console.WriteLine(hour + ":0{0}", Math.Floor(minute1));
            }
            else if(minute >=55)
            {
                hour++;
                double minute1 = minute + 15 - 60;
                Console.WriteLine(hour + ":{0}", minute1);
            }
            else if (minute < 45)
            {
                Console.WriteLine(hour + ":{0}", minute+15);
            }
        }
    }
}
