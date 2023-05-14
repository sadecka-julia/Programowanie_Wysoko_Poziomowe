using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    class OxygenBottle: ITransportable, IVisitPort
    {
        protected double volume, weight;
        public double MaxCapacity {get; set; }
        private double refillCost;

        public OxygenBottle(double maxCapacity)
        {
            this.MaxCapacity = maxCapacity;
            this.volume = maxCapacity;
            this.weight = 10;
            this.refillCost = 50;
        }
        public double VisitPort()
        {
            double cost = refillCost * (MaxCapacity - volume);
            volume = MaxCapacity;
            weight = volume * 10; 
            return cost;
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 30.0; // assume density equal to 30000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 30.0; // assume density equal to 30000 kg/m^3 (arbitrary number)
            }
        }
        public double RefillCost
        {
            get { return refillCost; }
            set
            {
                refillCost = value;
            }
        }
        public double GetCapacity()
        {
            return MaxCapacity;
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