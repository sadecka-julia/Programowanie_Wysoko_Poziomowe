using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziedziczenieInstrukcja
{
    internal class Animal
    {
        public string Name { get; set; }
        protected int Weight {get; set;}    
        private int Age { get; set; }
        public Animal(string animalName, int animalWeight)   // Konstruktor parametryczny
        {
            Name = animalName;
            Weight = animalWeight;
        }
        public Animal(){         // Konstruktor domyślny
            this.Name = "Brak";
            this.Age = 0;
            this.Weight = 0;
        }

        public void Napis()
        {
            Console.WriteLine("Jestem w klasie Animal. , {0}, {1}, {2}", Name, Age, Weight);
        }


    }
}