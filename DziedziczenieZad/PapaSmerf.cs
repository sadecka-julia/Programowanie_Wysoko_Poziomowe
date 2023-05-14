namespace DziedziczenieZad
{
    internal class PapaSmerf:WorkingSmerf
    {
        public int LiczbaZadan {get; set;}
        public PapaSmerf(string smerfName, int smerfAge, int smerfImportance, int smerfLiczbaZadan) : base(smerfName, smerfAge, smerfImportance){
            LiczbaZadan = smerfLiczbaZadan;
        }
        public void ZrobicEliksir(string problem)
        {
            base.Problem(problem);
            Console.WriteLine("Zrobiono eliksir na problem: {0}", problem);
        }
    }
}