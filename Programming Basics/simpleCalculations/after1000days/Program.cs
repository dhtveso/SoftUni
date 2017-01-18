using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace after1000days
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "dd-MM-yyyy";
            string Date = Console.ReadLine();
            DateTime userBirthday = DateTime.ParseExact(Date, format, null);
            Console.WriteLine(userBirthday.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
