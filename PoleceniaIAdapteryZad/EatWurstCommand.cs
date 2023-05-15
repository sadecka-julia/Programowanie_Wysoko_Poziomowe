namespace PoleceniaIAdapteryZad
{
    class EatWurstCommand: IVisitTouristAttraction
    {
        private Wurstelstand _wurstelstand;
        private string _type;
        private bool _withCheese;
        private bool _withKetchup;


        public EatWurstCommand(Wurstelstand wurstelstand, string type, bool withCheese, bool withKetchup)
        {
            _wurstelstand = wurstelstand;
            _type = type;
            _withCheese = withCheese;
            _withKetchup = withKetchup;
        }
        public void Visit()
        {
            _wurstelstand.WithChesse = _withCheese;
            _wurstelstand.WithKetchup = _withKetchup;
            _wurstelstand.EatWurst(_type);
        }

    }
}