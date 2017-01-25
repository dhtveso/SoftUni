using System;

namespace After1000days
{
    public class After100days
    {
        public static void Main()
        {
            string format = "dd-MM-yyyy";
            string Date = Console.ReadLine();
            DateTime userBirthday = DateTime.ParseExact(Date, format, null);
            Console.WriteLine(userBirthday.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
