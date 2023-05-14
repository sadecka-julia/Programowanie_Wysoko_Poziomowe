class ClassicWardrobe : Wardrobe {
    private int numberOfDoors;
    public int NumberOfDoors {
        get {
            return numberOfDoors;
        }
        set {
            numberOfDoors = value;
        }
    }

    public ClassicWardrobe(int setprice, string setcolor, int setnumberOfDoors): base(setprice, setcolor) {
        NumberOfDoors = setnumberOfDoors;
    }

    public override void Description() {
        Console.WriteLine($"This is a classic wardrobe with {numberOfDoors} doors.");
    }
}

