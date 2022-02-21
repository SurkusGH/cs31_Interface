using cs31_paskaita_Interface.Solution_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    // (1) Paverskite Car klasę abstrakčia ir pridėkite property string Model.
    public abstract class AbstractCar // <-- sukuriu klasę, nes nenoriu, kad ankstensis sprendimas nustotų veikti.
    {
        public string Model { get; set; } // <-- yra reikalavimas pridėti string Modėl. Bet jis yra ir ankstesnėje užduotyje?
        public int Fuel { get; set; }

        public AbstractCar(string model, int fuel)
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
                Console.WriteLine($"Bake yra {Fuel} litrų degalų - nuvažiuojamas atstumas: {5 * Fuel} KM");
            }

            if (Fuel == 0)
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
