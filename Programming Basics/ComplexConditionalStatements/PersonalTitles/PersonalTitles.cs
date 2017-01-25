using System;

namespace PersonalTitles
{
    public class PersonalTitles
    {
        public static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            var gander = Console.ReadLine();

            if (gander == "f")
            {
                //miss or ms
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (gander == "m")
            {
                //master or mr
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
