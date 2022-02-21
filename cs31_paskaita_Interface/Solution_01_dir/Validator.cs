using System;

namespace cs31_paskaita_Interface.Solution_01
{
    public class Validator
    {
        public static int InputValidation(int fuel)
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue >= 0 && (inputValue + fuel) <= 100;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.WriteLine("(!) Bake telpa iki 100 litrų kuro");
                Console.WriteLine("(!) Arba bandoma pilti neigiamą skaičių litrų kuro");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue >= 0 && (inputValue + fuel) <= 100;
            }
            return inputValue;
        }
    }
}
