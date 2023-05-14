class CastleManager
{
    private List<Crossbowman> crossbowmen = new List<Crossbowman>();
    private List<Pikeman> pikemen = new List<Pikeman>();
    private List<Inhabitant> inhabitants = new List<Inhabitant>();

    public void AddCrossbowman(Crossbowman crossbow)
    {
        crossbowmen.Add(crossbow);
        inhabitants.Add(crossbow);
    }
    public void AddPikeman(Pikeman pike)
    {
        pikemen.Add(pike);
        inhabitants.Add(pike);
    }
    public void AddInhabitant(Inhabitant inhab)
    {
        inhabitants.Add(inhab);
    }

    public void PrintCrossbowmenReadyToFight()
    {
        Console.WriteLine("Crossbowmen ready to fight:");
        foreach (var cross in crossbowmen)
        {
            Console.WriteLine($"{cross.ToString()}: {cross.ReadyToFight()}");
        }
    }

    public void PrintPikemenReadyToFight()
    {
        Console.WriteLine("Pikemen ready to fight:");
        foreach (var pike in pikemen)
        {
            Console.WriteLine($"{pike.ToString()}: {pike.ReadyToFight()}");
        }
    }
        public void PrintInhabitantsFood()
    {
        Console.WriteLine("Inhabitants food requirements:");
        foreach (var inhab in inhabitants)
        {
            Console.WriteLine($"{inhab.ToString()}: {inhab.Eat()}");
        }
    }
}
