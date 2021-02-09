using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Car is driving! Wooo!");
        }
    }
}
