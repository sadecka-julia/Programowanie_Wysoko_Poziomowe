namespace DziedziczenieZad
{
    internal class Smerf
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public string IdentificationMark {get; set;}
        public Smerf(string smerfName, int smerfAge)
        {
            Name = smerfName;
            Age = smerfAge;
            this.IdentificationMark = "Brak";
        }

        public void Problem(string problem)
        {
            Console.WriteLine("Jest problem: {0} \n", problem);
        }
        public void PrzedstawSie(){
            Console.WriteLine("Jestem {0}, mam {1} lat, mój znak rozpoznawczy to: {2}", Name, Age, IdentificationMark);
        }

    }
}