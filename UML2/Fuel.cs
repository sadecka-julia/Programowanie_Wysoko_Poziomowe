using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    abstract class Fuel:ITransportable
    {
        protected double volume, weight;
        public string Type { get; set; }
        protected double density;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 0.7; // assume density equal to 700 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 0.7; // assume density equal to 700 kg/m^3 (arbitrary number)
            }
        }
        public double Density
        {
            get { return density; }
            set
            {
                density = value;
            }
        }
        new public string GetType()
        {
            return Type;
        }
    }
}