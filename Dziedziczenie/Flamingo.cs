using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziedziczenieInstrukcja
{
    internal class Flamingo:Bird
    {
        public Flamingo(string animalName, int animalWeight, int birdFeathers) : base(animalName, animalWeight, birdFeathers)
        {
        }
        public void Incubation(int number, int days) // Metoda używająca konstruktora parametrycznego z innej klasy
        {
            base.LayEggs(number);
            Console.WriteLine("Będzie wysiadywane przez {0} dni", days);
        }
    }
}
