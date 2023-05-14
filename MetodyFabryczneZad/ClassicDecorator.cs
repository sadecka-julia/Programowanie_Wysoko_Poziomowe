public class ClassicDecorator : InteriorDecorator
{
    public override Desk MakeDesk(int priceLimit)
    {
        if (priceLimit < 500)
        {
            Console.WriteLine("Too small price limit to make Desk.");
            return null;
        }
        else if (priceLimit < 1000)
        {
            Console.WriteLine($"Made classic desk");
            return new ClassicDesk("Wood", 100);
        }
        else
        {
            Console.WriteLine($"Made classic desk");
            return new ClassicDesk("Wood", 200);
        }
    }

    public override Wardrobe MakeWardrobe(int priceLimit)
    {
        if (priceLimit < 1000)
        {
            Console.WriteLine("Too small price limit to make Wardrobe.");
            return null;
        }
        else if (priceLimit < 2000)
        {
            Console.WriteLine($"Made classic wardrobe for {priceLimit-50}");
            return new ClassicWardrobe(priceLimit-50, "brown", 6);
        }
        else
        {
            Console.WriteLine($"Made classic wardrobe for {priceLimit-50}");
            return new ClassicWardrobe(priceLimit-50, "brown", 10);
        }
    }
}