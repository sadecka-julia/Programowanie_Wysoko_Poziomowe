using System;
using System.Collections.Generic;
using System.Text;

namespace UML2
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew;
        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste waste, List<Human> crew)
        {
            oxygenBottles = bottles;
            foodContainer = container;
            this.waste = waste;
            this.crew = crew;
        }

        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            // oxygen
            double totalOxygenNeeded = 0;
            foreach (Human h in crew)
            {
                totalOxygenNeeded += h.OxygenConsumption * travelTime;
            }

            double totalOxygenAvailable = 0;
            foreach (OxygenBottle bottle in oxygenBottles)
            {
                totalOxygenAvailable += bottle.GetCapacity();
            }

            if (totalOxygenAvailable < totalOxygenNeeded)
            {
                return false; 
            }

            // food
            double totalFoodNeeded = 0;
            foreach (Human h in crew)
            {
                totalFoodNeeded += h.FoodConsumption * travelTime;
            }
            if (foodContainer.GetVolume() < totalFoodNeeded)
            {
                return false; 
            }

            return true;
        }

        public void Run(double travelTime)
        {
            int travelTimeLoop = (int)travelTime;
            for(int hour=0; hour<travelTime; hour++)
            {
                foreach (Human h in crew)
                {
                    // food
                    if(foodContainer.Volume >= 1)
                    {
                        foodContainer.Volume -= 0.25;
                    }
                    else
                    {
                        Console.WriteLine("There is not enough food!");
                    }
                    // oxygen
                    int bottle = 0;
                    int tmp = 0;
                    while (tmp == 0)
                    {
                        if(oxygenBottles[bottle].GetVolume() >= 1)
                        {
                            oxygenBottles[bottle].SetVolume(oxygenBottles[bottle].GetVolume() - 1);
                            tmp = 1;
                        }
                        else
                        {
                            if(bottle <= oxygenBottles.Count-1)
                            {
                                bottle += 1;
                            }
                            else
                            {
                                Console.WriteLine("There is not enough oxygen!");
                                tmp = 1;
                            }
                        }
                    }
                }
                //  waste
                waste.Volume += 10;
            }
        }
    }
}
