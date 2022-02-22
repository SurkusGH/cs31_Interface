using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_04_dir
{
    public class Dog : IAnimal, IMammal
    {
        //  (4) Sukurkite klasę Dog, kuri paveldės tiek iš IAnimal, tiek iš IMammal.
        //  (8) Implementuokite reikiamus metodus sukurtose klasėse.
        // (10) Implementuokite IComparable interface’ą visoms klasėms(pagal kokį property lyginti, pasirinkite patys, paprasčiau pagal vardą)
        public string Name { get; set; }
        public float Weight { get; set; }
        public bool LandDweller { get; set; }

        public Dog(string name, float weight, bool landDweller)
        {
            Name = name;
            Weight = weight;
            LandDweller = landDweller;
        }

        public void Eat()
        {
            Console.WriteLine("I am an animal and I can eat");
        }

        public void GiveBirth()
        {
            Console.WriteLine("I am a mammal and I can give birth");
        }
    }
}
