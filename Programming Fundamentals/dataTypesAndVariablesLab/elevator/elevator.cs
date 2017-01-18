using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    class elevator
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double capacityOfTheElevator = double.Parse(Console.ReadLine());

            double coursesOfElevator = (numberOfPeople / capacityOfTheElevator);

            Console.WriteLine(Math.Ceiling(coursesOfElevator));
        }
    }
}
