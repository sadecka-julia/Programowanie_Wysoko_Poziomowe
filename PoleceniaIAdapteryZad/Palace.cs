namespace PoleceniaIAdapteryZad
{
    class Palace
    {
        private string _name;
        private bool _withGarden;
        private bool _withMaze;
        private int _entryFee;
        private int _duration;
        public Palace (string name, int entryFee, int duration)
        {
            _name = name;
            _withGarden = false;
            _withMaze = false;
            _entryFee = entryFee;
            _duration = duration;
        }
        public void BuyTicket(bool withGarden, bool withMaze)
        {
            _withGarden = withGarden;
            _withMaze = withMaze;
            if(_withGarden && _withMaze)
            {
                _entryFee += 6;
                _duration += 60;
                Console.WriteLine($"Bought FULL ticket to {_name} for: {_entryFee}, with gardens and with Maze.");
            }
            else if(_withGarden && !_withMaze)
            {
                _entryFee += 3;
                _duration += 40;
                Console.WriteLine($"Bought GARDEN ticket to {_name} for: {_entryFee}, with gardens.");
            }
            else if(_withGarden && !_withMaze)
            {
                _entryFee += 3;
                _duration += 20;
                Console.WriteLine($"Bought MAZE ticket to {_name} for: {_entryFee}, with maze.");
            }
            else
            {
                Console.WriteLine($"Bought EASY ticket to {_name} for: {_entryFee}.");
            }
        }

        public void SeePalace()
        {
            Console.WriteLine("See Palace");
            if (_withGarden){
                Console.WriteLine("See Gardens");
            }
            if (_withMaze)
            {
                Console.WriteLine("See Maze");
            }
        }
    }
}