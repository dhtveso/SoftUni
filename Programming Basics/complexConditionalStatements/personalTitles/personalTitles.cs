using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personalTitles
{
    class personalTitles
    {
        static void Main(string[] args)
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
