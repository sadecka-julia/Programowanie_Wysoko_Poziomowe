namespace PoleceniaIAdapteryZad
{
    class TripScheduler
    {
        public Dictionary<int, IVisitTouristAttraction> Commands { get; set; }
        public void Run()
        {
            Console.WriteLine("----------------NEW TRIP---------------");
            for (int i = 0; i < 24; i++)
            {
                if(Commands.ContainsKey(i))
                {
                    Console.WriteLine("O godzinie " + i + ":00");
                    Commands[i].Visit();
                }
            }
        }
        public TripScheduler()
        {
            Commands = new Dictionary<int, IVisitTouristAttraction>();
        }

    }
}