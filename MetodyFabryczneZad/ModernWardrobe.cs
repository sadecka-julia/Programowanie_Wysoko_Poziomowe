class ModernWardrobe : Wardrobe {
    private string material;
    public string Material {
        get {
            return material;
        }
        set {
            material = value;
        }
    }

    public ModernWardrobe(int setprice, string setcolor, string setmaterial): base(setprice, setcolor) {
        Material = setmaterial;
    }

    public override void Description() {
        Console.WriteLine($"This is a modern wardrobe made of {material}.");
    }
}
