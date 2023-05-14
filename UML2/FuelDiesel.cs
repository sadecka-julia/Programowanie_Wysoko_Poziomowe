using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    class FuelDiesel:Fuel
    {
        public FuelDiesel()
        {
            Type = "diesel";
            density = 800.0;
        }
    }
}