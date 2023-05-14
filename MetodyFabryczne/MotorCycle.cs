using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Motorcycle: Vehicle
    {
        public Motorcycle(string _engine, int _vmax)
        {
            engine = _engine;
            vmax = _vmax;
        }
        public override string GetVehicleType()
        {
            return "motorcycle";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + ", Engine: " + engine + ", Vmax: " + vmax;
        }
    }