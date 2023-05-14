
internal class TrainFactory: VehicleFactory
{
    public override Train Create(/*string engine, int vmax*/)
    {
        string engine = "electric";
        int vmax = 120;
        return new Train(engine, vmax);
    }
}