using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The Three Wheeler is cruising!");
        }
    }
}
