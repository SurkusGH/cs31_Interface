using cs31_paskaita_Interface.Solution_01;
using System;
using System.Collections.Generic;

namespace cs31_paskaita_Interface
{
    // (!) Implement iComparer interface'ą ir kitiems automobilių tipams (taip suprantu Car) 
    public class Car : IVehicle
    {
        // Tada sukurkite klasę Car, kuri implementuos šį interface’ą ir taip pat turės properties string Model ir int Fuel.
        public string Model { get; set; }
        public int Fuel { get; set; }

        public Car(string model, int fuel)
        {
            Model = model;
            Fuel = fuel;
        }

        public void Drive()
        {
            // Implementuokite reikalingus metodus, Drive() metodas turi patikrinti ar degalai nėra pasibaigę, jeigu ne, važiuoti galima.
            Console.WriteLine($"Car model {Model} Cheking fuel:");
            if (Fuel > 0)
            {
                Console.WriteLine($"Bake yra {Fuel} litrų degalų - nuvažiuojamas atstumas: {5*Fuel} KM");
            }

            if(Fuel == 0)
            {
                Console.WriteLine($"Bakas tušias");
            }
        }

        public void Refuel()
        {
            // Refuel metodas turi patikrinti ar kiekis, kuriuo norima papildyti nėra minusinis
            // (galite padaryti ir maksimalų degalų bako dydį, bet pagalvokite, kaip tą funkcionalumą pernaudosite)
            Console.WriteLine($"Kiek degalų pilsite?");
            int fuelUp = Validator.InputValidation(Fuel);
            Fuel += fuelUp;
            Console.WriteLine($"Naujas degalų kiekis bake: {Fuel} litrų - naujas nuvažiuojamas atstumas: {5 * Fuel} KM");

        }
    }
}
