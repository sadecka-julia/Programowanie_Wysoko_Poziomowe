﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    interface ITransportable
    {
        // anything we can transport is ITransportable
        // examples: people, food, waste, fuel, equipment
        // each transportable item has to know its volume in m^3 and weight in tonnes
        // important: if you change volume, weight should update automatically and vice versa
        // you can use any numbers you want - don't worry about being realistic
		// see Equipment.cs for an example implementation
        double Volume { get; set; } 
        double Weight { get; set; }

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
