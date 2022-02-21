using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    public class Solution_03
    {
        // (!) Implement iComparer interface'ą ir kitiems automobilių tipams (taip suprantu Car) 
        public static void Solution_03_Run()
        {
            var carList = new List<Car> { new Car("Audi A6", 5), new Car("Audi A8", 5), new Car("Audi B2", 5),
                                          new Car("VW ID", 5), new Car("VW Passat", 5), new Car("VW Golf", 5), 
                                          new Car("Shkoda 1", 5), new Car("Shkoda 7", 5), new Car("Shkoda L", 5)};
            var carComparer = new CarComparer();

            Console.WriteLine("Prieš sort:");
            carList.ForEach(item => Console.WriteLine(item.Model));
            Console.WriteLine();

            Console.WriteLine("Po sort:");
            carList.Sort(carComparer);
            carList.ForEach(item => Console.WriteLine(item.Model));
            Console.WriteLine();
        }
    }
}
