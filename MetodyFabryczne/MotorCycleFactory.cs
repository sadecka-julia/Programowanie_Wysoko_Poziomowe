
internal class MotorCycleFactory: VehicleFactory
{
    public override Motorcycle Create(/*string engine, int vmax*/)
    {
        string engine = "electric";
        int vmax = 90;
        return new Motorcycle(engine, vmax);
    }
}