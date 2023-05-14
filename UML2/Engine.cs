using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste;

        public Engine(FuelTank tank, Waste waste)
        {
            this.tank = tank;
            this.waste = waste;
        }

        public double GetVelocity(double submarineWeight)
        {
            return submarineWeight * 2.0;
        }

        public bool CheckFuelBeforeTravel(double travelTime)
        {
            double fuelConsumption = travelTime * tank.GetCapacity() * 0.1; 
            if (fuelConsumption > tank.Volume)
            {
                Console.WriteLine("Not enough fuel for travel!");
                return false;
            }
            else
            {
                Console.WriteLine("Enough fuel for travel.");
                return true;
            }
        }
        public void Travel(double travelTime)
        {
            double fuelConsumption = travelTime * tank.GetCapacity() * 0.1;

            if (CheckFuelBeforeTravel(travelTime))
            {                
                tank.Volume -= fuelConsumption;
                waste.Volume += fuelConsumption;
            }
            else
            {
                Console.WriteLine("Travel aborted.");
            }
        }
    }
}