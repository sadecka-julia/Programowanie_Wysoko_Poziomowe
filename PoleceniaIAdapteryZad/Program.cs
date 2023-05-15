using System;

namespace PoleceniaIAdapteryZad
{
    class Program
    {
        static void Main(string[] args)
        {
            CityHall viennaCityHall = new CityHall(11, 45);
            Opera viennaOperahouse = new Opera("Vienna Operahouse", 17.5, 22.5);
            Palace schonbrunnPalace = new Palace("Schonbrunn Palace", 13, 70);
            Wurstelstand viennaWurst = new Wurstelstand("Albertina 12", 5);

            TripScheduler scheduler = new TripScheduler();
            VisitCityHallCommand place1 = new VisitCityHallCommand(viennaCityHall, 18);
            VisitOperaCommand place2 = new VisitOperaCommand(viennaOperahouse, "Romeo And Julia", 21.2);
            VisitPalaceCommand place3 = new VisitPalaceCommand(schonbrunnPalace, true, false);
            EatWurstCommand place4 = new EatWurstCommand(viennaWurst, "CurryWurst", true, false);
            scheduler.Commands.Add(15, place3);
            scheduler.Commands.Add(18, place1);
            scheduler.Commands.Add(20, place4);
            scheduler.Commands.Add(21, place2);
            scheduler.Run();

            /*TripScheduler scheduler = new TripScheduler();
            VisitCityHallCommand place1 = new VisitCityHallCommand(viennaCityHall, 18);
            VisitOperaCommand place2 = new VisitOperaCommand(viennaOperahouse, "Romeo And Julia", 21.2);
            VisitPalaceCommand place3 = new VisitPalaceCommand(schonbrunnPalace, true, false);
            EatWurstCommand place4 = new EatWurstCommand(viennaWurst, "CurryWurst", true, false);
            scheduler.Commands.Add(15, place3);
            scheduler.Commands.Add(18, place1);
            scheduler.Commands.Add(20, place4);
            scheduler.Commands.Add(21, place2);
            scheduler.Run();


            TripScheduler scheduler = new TripScheduler();
            VisitCityHallCommand place1 = new VisitCityHallCommand(viennaCityHall, 18);
            VisitOperaCommand place2 = new VisitOperaCommand(viennaOperahouse, "Romeo And Julia", 21.2);
            VisitPalaceCommand place3 = new VisitPalaceCommand(schonbrunnPalace, true, false);
            EatWurstCommand place4 = new EatWurstCommand(viennaWurst, "CurryWurst", true, false);
            scheduler.Commands.Add(15, place3);
            scheduler.Commands.Add(18, place1);
            scheduler.Commands.Add(20, place4);
            scheduler.Commands.Add(21, place2);
            scheduler.Run();
            */

        }
    }
}