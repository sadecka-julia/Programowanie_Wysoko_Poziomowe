using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziedziczenieInstrukcja
{
    internal class Bird:Animal  // Klasa która dziedziczy po klasie Animal
    // W klasach dziedziczonych nie można odwoływać się do zmiennych private, 
    // Ponieważ ich można użyć tylko w danej klasie. Protected można użyć w danej klasie i klasach dziedziczących po niej
    {
        public int Feathers {get; set;}
        // Konstruktor parametryczny dziedziczący z klasy Animal
        public Bird(string animalName, int animalWeight, int birdFeathers) : base(animalName, animalWeight)
        {
            birdFeathers = Feathers;
        }
        public void Napis2()
        {
            //base.Napis();
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("weight {0}", Weight);
        }

        public void LayEggs(int number)
        {
            Console.WriteLine("{0} jaj zostało zniesionych przez {1}", number, Name);
        }
        
    }
}
