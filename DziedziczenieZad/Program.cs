namespace DziedziczenieZad;
class Program
{
    static void Main(string[] args)
    {
        Smerf wazniak = new Smerf("Ważniak", 2);
        wazniak.IdentificationMark = "Okulary";
        wazniak.Problem("choroba");
        wazniak.PrzedstawSie();
        Console.WriteLine("------------------------------------------");

        PapaSmerf papa = new PapaSmerf("Papa Smerf", 70, 10, 16);
        papa.ZrobicEliksir("choroba");   
        papa.PrzedstawSie(); 
        Console.WriteLine("------------------------------------------"); 

        EmotionalSmerf maruda = new EmotionalSmerf("Maruda", 3, 4);
        maruda.PrzedstawSie();   
    }
}
