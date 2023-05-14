public class ScandinavianDesk : Desk
{
    private int numberOfDoors;
    public int NumberOfDoors {
        get {
            return numberOfDoors;
        }
        set {
            numberOfDoors = value;
        }
    }
    public ScandinavianDesk(string setmaterial, int setnumberOfDoors, int setprice): base(setmaterial)
    {
        Price = setprice;
        NumberOfDoors = setnumberOfDoors;
    }
    public override void Description() {
        Console.WriteLine($"This is a scandinavian desk made of {Material} and with {NumberOfDoors} doors.");
    }

}