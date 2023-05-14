using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    class FoodContainer:ITransportable, IVisitPort
    {
        protected double volume, weight;
        public double MaxCapacity {get; set; }
        private double refillCost;

        public FoodContainer(double maxCapacity)
        {
            this.MaxCapacity = maxCapacity;
            this.volume = maxCapacity;
            this.weight = 13;
            this.refillCost = 70;
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
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
        public double VisitPort()
        {
            double cost = refillCost * (MaxCapacity - volume);
            volume = MaxCapacity;
            weight = volume * 0.5; 
            return cost;
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