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

            Solution_01x.Solution_01x_Run(); // <-- Pilti negalima nei kad total bųtų daugiau nei 100, nei kad pilamas neigiamas skaičius
        }
    }
}
