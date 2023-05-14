class ScandinavianWardrobe : Wardrobe {
    private bool slidingDoors;
    public bool SlidingDoors {
        get {
            return slidingDoors;
        }
        set {
            slidingDoors = value;
        }
    }

    public ScandinavianWardrobe(int setprice, string setcolor, bool setslidingDoors): base(setprice, setcolor) {
        SlidingDoors = setslidingDoors;
    }

    public override void Description() {
        if (slidingDoors) {
            Console.WriteLine("This is a Scandinavian wardrobe with sliding doors.");
        } else {
            Console.WriteLine("This is a Scandinavian wardrobe with hinged doors.");
        }
    }
}