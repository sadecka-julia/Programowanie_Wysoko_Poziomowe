
internal class Train:Vehicle
{
    public Train(string engine, int velocityLimit)
    {
        Engine = engine;
        VelocityLimit = velocityLimit;
    }
    public override string GetVehicleType()
    {
        return "Train";
    }
}
