using System;
using System.Collections.Generic;

namespace cs31_paskaita_Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs31_PASKAITA_Interface ir ICompatable!");
            #region TEORIJA
            //interface yra kontraktas -  kurį klasė pasirašo įvykdyti norėdama jį implementuoti
            var pizzas = new List<IPizza> { new NewYorkPizza(), new CheesePizza()};
            pizzas.ForEach(pizzas => pizzas.Prepare());
            #endregion

        }
        // Sukurkite interface’ą pavadinimų IVehicle su metodais Drive ir Refuel(grąžinimo tipą galit pasirinkti patys ir
        // tai kaip jį implementuosit, galite daryti ir su void)
        // Tada sukurkite klasę Car, kuri implementuos šį interface’ą ir taip pat turės properties string Model ir int Fuel.
        // Implementuokite reikalingus metodus, Drive() metodas turi patikrinti ar degalai nėra pasibaigę, jeigu ne, važiuoti galima.
        // Refuel metodas turi patikrinti ar kiekis, kuriuo norima papildyti nėra minusinis(galite padaryti ir maksimalų degalų bako dydį, 
        // bet pagalvokite, kaip tą funkcionalumą pernaudosite)
    }
}
