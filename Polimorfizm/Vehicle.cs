
abstract class Vehicle
{
    private string engine;
    private int velocityLimit;

    public string Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public int VelocityLimit
    {
        get { return velocityLimit; }
        set { velocityLimit = value; }
    }
    public virtual string GetVehicleType()
    {
        return "Unspecific Type";
    }
    public override string ToString()
    {
        return "Vehicle type: " + GetVehicleType() + ". Engine: " + Engine + ". Velocity limit: " + VelocityLimit + " km/h";
    }
}