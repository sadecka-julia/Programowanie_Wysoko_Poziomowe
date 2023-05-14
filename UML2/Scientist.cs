using System;

namespace UML2
{
    class Scientist : Human
    {
        private Equipment equipment;

        public Scientist(Equipment equipment)
        {
            this.equipment = equipment;
        }

        public void Work(double time)
        {
            equipment.GatherData();
            double equipmentVolume = equipment.Volume;
            double equipmentWeight = equipment.Weight;
            for (int i = 0; i < Math.Ceiling(time / 24); i++) //use every 24h
            {
                equipment.Volume -= equipmentVolume;
                equipment.Weight -= equipmentWeight;
            }
        }
    }
}
