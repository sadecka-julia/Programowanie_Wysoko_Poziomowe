using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    abstract class Human: ITransportable
    {
        protected double volume, weight;
        public double OxygenConsumption {get; set;}
        public double FoodConsumption {get; set;}

        public Human()
        {
            OxygenConsumption = 10.0;
            FoodConsumption = 8.0;
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 1.0; // assume density equal to 1000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 1.0; // assume density equal to 1000 kg/m^3 (arbitrary number)
            }
        }
        /*public double OxygenConsumption
        {
            get { return oxygenConsumption; }
            set
            {
                oxygenConsumption = value;
            }
        }
        public double FoodConsumption
        {
            get { return foodConsumption; }
            set
            {
                foodConsumption = value;
            }
        }*/
    }
}