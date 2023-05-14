
internal class CarFactory:VehicleFactory
{
    public override Car Create(/*string engine, int vmax*/)
    {
        List<Engine> engine = new List<Engine>();
        engine.Add("hybrid");
        engine.Add("diesel");
        engine.Add("electric");
        engine.Add("petrol engine");
        Random rnd = new Random();

        string engineType = engine[rnd.Next(0, engine.Count-1)];
        int vmax = 150;
        return new Car(engineType, vmax);
    }
}