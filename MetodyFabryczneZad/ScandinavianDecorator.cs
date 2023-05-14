public class ScandinavianDecorator : InteriorDecorator
{
    public override Desk MakeDesk(int priceLimit)
    {
        if (priceLimit < 1500)
        {
            Console.WriteLine("Too small price limit to make Desk.");
            return null;
        }
        else
        {
            Console.WriteLine($"Made scandinavian desk for {priceLimit}");
            return new ScandinavianDesk("Wood", 4, priceLimit);
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
            Console.WriteLine($"Made scandinavian wardrobe for {priceLimit}");
            return new ScandinavianWardrobe(priceLimit, "grey", false);
        }
        else
        {
            Console.WriteLine($"Made scandinavian wardrobe for {priceLimit}");
            return new ScandinavianWardrobe(priceLimit, "brown", true);
        }
    }
}