public class ClassicDesk : Desk
{
    private int size;
    public int Size {
        get {
            return size;
        }
        set {
            size = value;
        }
    }
    public ClassicDesk(string setmaterial, int setsize): base(setmaterial)
    {
        Size = setsize;
        Price = Size * 2;       
    }
    public override void Description() {
        Console.WriteLine($"This is a classic desk with {size} size.");
    }
}