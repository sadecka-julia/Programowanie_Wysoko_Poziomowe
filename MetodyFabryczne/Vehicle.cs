abstract class Vehicle
    {
        public virtual string GetVehicleType()
        {
            return "unspecified vehicle";
        }

        public string engine = string.Empty;
        public int vmax = 0;
    }