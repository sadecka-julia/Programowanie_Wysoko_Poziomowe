public class ModernDecorator : InteriorDecorator
{
    public override Desk MakeDesk(int priceLimit)
    {
        if (priceLimit < 1000)
        {
            Console.WriteLine("Too small price limit to make Desk.");
            return null;
        }
        else
        {
            Console.WriteLine($"Made modern desk ");
            return new ModernDesk("Metal", "Green");
        }
    }

    public override Wardrobe MakeWardrobe(int priceLimit)
    {
        if (priceLimit < 900)
        {
            Console.WriteLine("Too small price limit to make Wardrobe.");
            return null;
        }
        else if (priceLimit < 1500)
        {
            Console.WriteLine($"Made modern wardrobe for {priceLimit-70}");
            return new ModernWardrobe(priceLimit-70, "brown", "Plastic");
        }
        else
        {
            Console.WriteLine($"Made modern wardrobe for {priceLimit-70}");
            return new ModernWardrobe(priceLimit-70, "brown", "Metal and Wood");
        }
    }
}