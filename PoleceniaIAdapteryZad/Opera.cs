namespace PoleceniaIAdapteryZad
{
    class Opera
    {
        private string _name;
        private double _openingHour;
        private double _closingHour;
        public Opera(string name, double openingHour, double closingHour)
        {
            _name = name;
            _openingHour = openingHour;
            _closingHour = closingHour;
        }
        public void SeeOpera(string title, double hour)
        {
            if(hour>_openingHour && hour < _closingHour)
            {
                Console.WriteLine($"See {title} opera in {_name}");
            }
            else
            {
                Console.WriteLine("In this time there is no Opera.");
            }
        }
    }
}