
namespace PoleceniaIAdapteryZad
{
    class VisitPalaceCommand : IVisitTouristAttraction
    {
        private Palace _palace;
        private bool _withGarden;
        private bool _withMaze;
        public VisitPalaceCommand(Palace palace, bool withGarden, bool withMaze)
        {
            _palace = palace;
            _withGarden = withGarden;
            _withMaze = withMaze;
        }

        public void Visit()
        {
            _palace.BuyTicket(_withGarden, _withMaze);
            _palace.SeePalace();
        }
    }
}