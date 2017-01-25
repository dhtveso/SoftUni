using System;

namespace Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double capacityOfTheElevator = double.Parse(Console.ReadLine());

            double coursesOfElevator = (numberOfPeople / capacityOfTheElevator);

            Console.WriteLine(Math.Ceiling(coursesOfElevator));
        }
    }
}
