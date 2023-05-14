using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    class FuelTank:ITransportable, IVisitPort
    {
        public double MaxCapacity { get; set; }
        private Fuel fuel;
        protected double volume, weight;

        public FuelTank(double maxCapacity, Fuel fuelType)
        {
            MaxCapacity = maxCapacity;
            fuel = fuelType;
        }

        public double VisitPort()
        {
            Volume = MaxCapacity;
            double cost = Volume * fuel.Density * 0.5; 
            return cost;
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 6.0; // assume density equal to 6000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 6.0; // assume density equal to 6000 kg/m^3 (arbitrary number)
            }
        } 
        public double GetCapacity()
        {
            return MaxCapacity;
        }

        public string GetFuelType()
        {
            return fuel.Type;
        }
        public double GetVolume() 
        { 
            return Volume; 
        }
        public double GetWeight() 
        { 
            return Weight; 
        }
        public void SetVolume(double volume) 
        { 
            Volume = volume; 
        }
        public void SetWeight(double weight) 
        { 
            Weight = weight; 
        }      
    }
}