namespace PoleceniaIAdapteryZad
{
    class Wurstelstand
    {
        private string _adress;
        private int _price;
        private bool _withCheese;
        private bool _withKetchup;

        public virtual bool WithChesse
        {
            get {   return _withCheese; }
            set {   _withCheese = value; }
        }

        public virtual bool WithKetchup
        {
            get {   return _withKetchup; }
            set {   _withKetchup = value; }
        }
        public Wurstelstand(string adress, int smallestPrice)
        {
            _adress = adress;
            _price = smallestPrice;
        }
        public void EatWurst(string type)
        {
            if(_withCheese)
            {
                _price += 1;
            }
            if (_withKetchup)
            {
                _price += 1;
            }
            Console.WriteLine($"Eat {type}, for: {_price}");
        }
    }
}