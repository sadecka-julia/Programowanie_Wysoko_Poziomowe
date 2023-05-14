using System;

class Program
{
    static void Main(string[] args)
    {
        InteriorDecorator classicDecorator = new ClassicDecorator();
        InteriorDecorator modernDecorator = new ModernDecorator();
        InteriorDecorator scandinavianDecorator = new ScandinavianDecorator();

        Console.WriteLine("Make desks");
        Desk classicDesk = classicDecorator.MakeDesk(500);
        Desk modernDesk = modernDecorator.MakeDesk(1000);
        Desk scandinavianDesk = scandinavianDecorator.MakeDesk(1500);

        Console.WriteLine("\nMake Wardrobe");
        Wardrobe classicWardrobe = classicDecorator.MakeWardrobe(700);
        Wardrobe modernWardrobe = modernDecorator.MakeWardrobe(1200);
        Wardrobe scandinavianWardrobe = scandinavianDecorator.MakeWardrobe(1700);

        Console.WriteLine("\nProduced desks:");
        if (classicDesk != null) 
        {
            classicDesk.Description();
            Console.WriteLine($"Classic desk: {classicDesk.GetType().Name}");
        }
        if (modernDesk != null)
        {
            Console.WriteLine($"Modern desk: {modernDesk.GetType().Name}");
        }
        if (scandinavianDesk != null) 
        {
            Console.WriteLine($"Art deco desk: {scandinavianDesk.GetType().Name}");
        }

        Console.WriteLine("\nProduced wardrobes:");
        if (classicWardrobe != null) 
        {
            Console.WriteLine($"Classic wardrobe: {classicWardrobe.GetType().Name}");
        }
        if (modernWardrobe != null) 
        {
            Console.WriteLine($"Modern wardrobe: {modernWardrobe.GetType().Name}");
        }
        if (scandinavianWardrobe != null) 
        {
            Console.WriteLine($"Art deco wardrobe: {scandinavianWardrobe.GetType().Name}");
        }
        
    }
}
