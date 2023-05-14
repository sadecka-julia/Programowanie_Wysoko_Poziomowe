namespace DziedziczenieZad
{
    internal class EmotionalSmerf:Smerf
    {
        public int Annoying {get; set;}
        public EmotionalSmerf(string smerfName, int smerfAge, int smerfAnnoying) : base(smerfName, smerfAge)
        {
            Annoying = smerfAnnoying;
        }
    }
}