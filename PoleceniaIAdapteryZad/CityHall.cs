namespace PoleceniaIAdapteryZad
{
    class CityHall
    {
        private bool _isConcert;
        private decimal _price;
        private int _duration;
        public void Explore(int time)
        {
            if ( time >= 18 && time < 23)
            {
                _isConcert = true;
                _price += 5;
                _duration += 90;
            }
            Console.WriteLine($"Explore Vienna City Hall for {_duration} minutes, price: {_price}. Will be there a concert: {_isConcert}");
        }
        public CityHall(int price, int duration)
        {
            _isConcert = false;
            _price = price;
            _duration = duration;
        }

    }
}