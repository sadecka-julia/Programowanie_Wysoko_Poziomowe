using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    class FuelNuclear:Fuel
    {
        public FuelNuclear()
        {
            Type = "nuclear";
            density = 700.0; //gestosc
        }
    }
}