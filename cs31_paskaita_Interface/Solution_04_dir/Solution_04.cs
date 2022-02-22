using cs31_paskaita_Interface.Solution_04_dir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    public class Solution_04
    {
        //  (1) Sukurkite interface’ą IAnimal, jis turės metodus visus būdingus visiems gyvūnams, pvz Eat().
        //  (2) Sukurkite interface’ą IMammal, jis turės metodus būdingus žinduoliams, pvz GiveBirth().
        //  (3) Sukurkite interface’ą IFish, jis turės metodus būdingus žuvims, pvz Swim().
        //  (4) Sukurkite klasę Dog, kuri paveldės tiek iš IAnimal, tiek iš IMammal.
        //  (5) Sukurkite klasę Cat, kuri paveldės tiek iš IAnimal, tiek iš IMammal.
        //  (6) Sukurkite klasę Bass, kuri paveldės tiek iš IAnimal, tiek iš IFish.
        //  (7) Sukurkite klasę Carp, kuri paveldės tiek iš IAnimal, tiek iš IFish.

        //  (8) Implementuokite reikiamus metodus sukurtose klasėse.
        public static void Solution_04_Run()
        {
            //  (9) Sukurkite sąrašą IAnimal, IMammal, IFish, iteruokite per sąrašus ir paleiskite metodus būdingus tiems interface’ams.
            var animalList = new List<IAnimal> { new Dog( "Pifas", 15, true), new Dog ("Rūkas", 35, true), new Dog("Big", 100, true) };
            var mammalList = new List<IMammal> { new Cat("Mifas", 85, true), new Cat("Pūkas", 95, true), new Cat("Feliksas", 75, true) };
            var fishList = new List<IFish> { new Carp("CCC", 3, false), new Carp("AAA", 1, false), new Carp("BBB", 2, false) };

            animalList.ForEach(animal => animal.Eat());
            animalList.ForEach(animal => Console.WriteLine((animal as Dog).Name));
            Console.WriteLine();

            mammalList.ForEach(animal => animal.GiveBirth());
            mammalList.ForEach(animal => Console.WriteLine((animal as Cat).Name));
            Console.WriteLine();

            fishList.ForEach(animal => animal.Swim());
            fishList.ForEach(animal => Console.WriteLine((animal as Carp).Name));
            Console.WriteLine();

            // (10) Implementuokite IComparable interface’ą visoms klasėms(pagal kokį property lyginti, pasirinkite patys, paprasčiau pagal vardą)
            var dogComparer = new DogComparer();
            var animalListDogDataType = new List<Dog> { new Dog("Pifas", 15, true), new Dog("Rūkas", 35, true), new Dog("Big", 100, true) };

            Console.WriteLine("Prieš sort:");
            animalListDogDataType.ForEach(item => Console.WriteLine(item.Name));
            Console.WriteLine();

            Console.WriteLine("Po sort:");
            animalListDogDataType.Sort(dogComparer);
            animalListDogDataType.ForEach(item => Console.WriteLine(item.Name));
            Console.WriteLine();

            var catComparer = new CatComparer();
            var mammalListCatDataType = new List<Cat> { new Cat("Mifas", 85, true), new Cat("Pūkas", 95, true), new Cat("Feliksas", 75, true) };

            Console.WriteLine("Prieš sort:");
            mammalListCatDataType.ForEach(item => Console.WriteLine(item.Weight));
            Console.WriteLine();

            Console.WriteLine("Po sort:");
            mammalListCatDataType.Sort(catComparer);
            mammalListCatDataType.ForEach(item => Console.WriteLine(item.Weight));
            Console.WriteLine();

            //Console.WriteLine("Prieš sort:");
            //animalList.ForEach(item => Console.WriteLine((item as Dog).Name));
            //Console.WriteLine();

            //Console.WriteLine("Po sort:");
            //animalList.Sort(dogComparer); // <-- ???
            //animalList.ForEach(item => Console.WriteLine((item as Dog).Name));
            //Console.WriteLine();
        }



    }
}
