using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Car: Vehicle
    {
        public Car(string _engine, int _vmax)
        {
            engine = _engine;
            vmax = _vmax;
        }
        public override string GetVehicleType()
        {
            return "car";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + ", Engine: " + engine + ", Vmax: " + vmax;
        }
    }