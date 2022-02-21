using System;
using System.Collections.Generic;

namespace cs31_paskaita_Interface
{
    public class Solution_02
    {

        //     Pamodifikuoti pirmos užduoties programą
        // (1) Paverskite Car klasę abstrakčia ir pridėkite property string Model.
        // (2) Sukurkite klasę BmwCar, kuri paveldės iš klasės Car ir turės savo property Bool IsXdrive.
        // (3) Sukurkite klasę AudiCar, kuri paveldės iš klasės Car ir turės savo property bool IsQuattro.
        public static void Solution_02_Run()
        {
            var bmwCarsList = new List<BmwCar> { new BmwCar(true, "BMW Z1", 10), new BmwCar(false, "BMW A1", 10), new BmwCar(true, "BMW X5", 10) };
            var bmwComparer = new BMWCarComparer();

            Console.WriteLine("Prieš sort:");
            bmwCarsList.ForEach(item => Console.WriteLine(item.Model));
            Console.WriteLine();

            Console.WriteLine("Po sort:");
            bmwCarsList.Sort(bmwComparer);
            bmwCarsList.ForEach(item => Console.WriteLine(item.Model));
            Console.WriteLine();

            var audiCarsList = new List<AudiCar> { new AudiCar(true, "Audi F1", 10), new AudiCar(true, "Audi Z1", 10), new AudiCar(true, "Audi A1", 10) };
            var audiComparer = new AUDICarComparer();

            Console.WriteLine("Prieš sort:");
            audiCarsList.ForEach(item => Console.WriteLine(item.Model));
            Console.WriteLine();

            Console.WriteLine("Po sort:");
            audiCarsList.Sort(audiComparer);
            audiCarsList.ForEach(item => Console.WriteLine(item.Model));
            Console.WriteLine();
        }
    }
}
