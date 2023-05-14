public abstract class Desk
{
    private int price;
    public int Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }

    private string material;
    public string Material
    {
        get
        {
            return material;
        }
        set
        {
            material = value;
        }
    }
    public Desk(string setmaterial)
    {
        Material = setmaterial;
    }
    public virtual void Description() {
        Console.WriteLine("This is a generic desk.");
    }
}
