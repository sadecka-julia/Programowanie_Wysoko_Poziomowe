class Pikeman : Defender
{
    public override int Eat()
    {
        return 4;
    }

    public override string ToString()
    {
        return "Pikeman";
    }
    public override string ReadyToFight()
    {
        return "Ready to defend!";
    }
}