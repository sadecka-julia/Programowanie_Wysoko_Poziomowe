namespace PoleceniaIAdapteryZad
{
    class VisitOperaCommand : IVisitTouristAttraction
    {
        private Opera _opera;
        private string _title;
        private double _hour;
        public VisitOperaCommand(Opera opera, string title, double hour)
        {
            _opera = opera;
            _title = title;
            _hour = hour;
        }
        public void Visit()
        {
            _opera.SeeOpera(_title, _hour);
        }
    }
}