using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    public class Solution_01x
    {
        // Sukurkite interface’ą pavadinimų IVehicle su metodais Drive ir Refuel
        // (grąžinimo tipą galit pasirinkti patys ir tai kaip jį implementuosit, galite daryti ir su void)

        // Tada sukurkite klasę Car, kuri implementuos šį interface’ą ir taip pat turės properties string Model ir int Fuel.

        // Implementuokite reikalingus metodus, Drive() metodas turi patikrinti ar degalai nėra pasibaigę, jeigu ne, važiuoti galima.

        // Refuel metodas turi patikrinti ar kiekis, kuriuo norima papildyti nėra minusinis
        // (galite padaryti ir maksimalų degalų bako dydį, bet pagalvokite, kaip tą funkcionalumą pernaudosite)

        public static void Solution_01x_Run()
        {

            var car1 = new Car("Golf", 20);
            var car2 = new Car("A3", 0);


            car1.Drive();
            car1.Refuel();
            Console.WriteLine();

            car2.Drive();
            car2.Refuel();
            Console.WriteLine();


        }
    }
}
