class Crossbowman : Defender
{
    public override int Eat()
    {
        return 3;
    }

    public override string ToString()
    {
        return "Crossbowman";
    }

    public override string ReadyToFight()
    {
        return "Ready to shoot!";
    }
}