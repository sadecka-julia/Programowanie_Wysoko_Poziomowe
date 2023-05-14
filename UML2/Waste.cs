using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    class Waste:ITransportable, IVisitPort
    {
        protected double volume, weight;
        private double emptyCost;

        public Waste()
        {
            this.emptyCost = 50;
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
        public double EmptyCost
        {
            get { return emptyCost; }
            set
            {
                emptyCost = value;
            }
        }
        public double VisitPort()
        {
            double cost = emptyCost * volume;
            volume = 0;
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