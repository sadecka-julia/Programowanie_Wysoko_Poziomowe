using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziedziczenieInstrukcja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird pies = new Bird("wrona", 8, 516);
            pies.Napis();
            pies.LayEggs(2);
            Flamingo pinkFlamingo = new Flamingo("pinky", 3, 983);
            Animal zwierze = new Animal("lew", 4);
            zwierze.Napis();
        }
    }
}