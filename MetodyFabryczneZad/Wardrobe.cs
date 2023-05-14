public abstract class Wardrobe {
    protected int price;
    public int Price {
        get {
            return price;
        }
        set {
            price = value;
        }
    }
    protected string color;
    public string Color {
        get {
            return color;
        }
        set {
            color = value;
        }
    }
    public Wardrobe(int setprice, string setcolor)
    {
        this.Price = setprice;
        this.Color = setcolor;
    }

    public virtual void Description() {
        Console.WriteLine("This is a generic wardrobe.");
    }
}
