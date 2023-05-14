public class ModernDesk : Desk
{
    
    private string color;
    public string Color {
        get {
            return color;
        }
        set {
            color = value;
        }
    }

    public ModernDesk(string setmaterial, string setcolor): base(setmaterial)
    {
        Price = 1500;
        Color = setcolor;
    }
    public override void Description() {
        Console.WriteLine($"This is a modern desk made of {Material} and in color {Color}.");
    }
}