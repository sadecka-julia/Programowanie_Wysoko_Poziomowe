using System;
using System.Collections.Generic;

namespace PolimorfizmZad
{
    class Program
    {
        static void Main(string[] args)
        {
            CastleManager castle = new CastleManager();
            castle.AddCrossbowman(new Crossbowman());
            castle.AddCrossbowman(new Crossbowman());
            castle.AddPikeman(new Pikeman());
            castle.AddPikeman(new Pikeman());
            castle.AddInhabitant(new Civilian());
            castle.AddInhabitant(new Civilian());
            castle.AddInhabitant(new Civilian());

            castle.PrintCrossbowmenReadyToFight();
            castle.PrintPikemenReadyToFight();
            castle.PrintInhabitantsFood();
        }
    }
}

