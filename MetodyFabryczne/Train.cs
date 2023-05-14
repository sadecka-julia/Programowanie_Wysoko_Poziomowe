using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 internal class Train : Vehicle
    {
        public Train(string _engine, int _vmax)
        {
            engine = _engine;
            vmax = _vmax;
        }
        public override string GetVehicleType()
        {
            return "train";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + ", Engine: " + engine + ", Vmax: " + vmax;
        }
    }