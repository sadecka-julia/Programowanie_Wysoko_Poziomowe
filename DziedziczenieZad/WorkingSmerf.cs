namespace DziedziczenieZad
{
    internal class WorkingSmerf:Smerf
    {
        public int Importance {get; set;}
        public WorkingSmerf(string smerfName, int smerfAge, int smerfImportance) : base(smerfName, smerfAge)
        {
            Importance = smerfImportance;
        }
    }
}