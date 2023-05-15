namespace PoleceniaIAdapteryZad
{
    class VisitCityHallCommand : IVisitTouristAttraction
    {
        private CityHall _cityHall;
        private int _time;
        public VisitCityHallCommand(CityHall cityHall, int time)
        {
            _cityHall = cityHall;
            _time = time;
        }
        public void Visit()
        {
            _cityHall.Explore(_time);
        }
    }
}