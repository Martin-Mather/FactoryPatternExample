using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of tires of the vehicle you want to create:");
                //int wheelCount;

                input = int.TryParse(Console.ReadLine(), out numOfWheels);
            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();

        }
    }
}
