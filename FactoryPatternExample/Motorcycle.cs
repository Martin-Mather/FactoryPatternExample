using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Motorcycle is revving up!");
            Console.WriteLine("Vroooooom");
        }
    }
}
