using cs31_paskaita_Interface.Solution_05_dir;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_06_dir
{
    public class Solution_06
    {
        public static string coordinates = @"D:\GitHub\cs31_paskaita_Interface\cs31_paskaita_Interface\Solution_06_dir\Rinkmena.txt";
        // (1) Sukurkite interface’ą IWriteableToFile
        // (2) Jis turės metodą WriteToFile(string fileName)
        // (3) Klasė implementuojanti jį append’ins savo ToString() (overrideinkit, kad išspausdintų objekto properties) į nurodytą failą.
        // (4) Implementuokite visose sukurtose klasėse, tada sukūrę sąrašą visų objektų, iteruokite per visus ir surašykite į failą.
        // (!) P.S.Failo įrašymo funkcionalumas kartosis daugelyje vietų, gal verta pabandyti iškelti ir pernaudoti?

        public static void Solution_06_Run()
        {
            var triangleList = new List<Triangle> { new Triangle(5, 2), new Triangle(1, 2), new Triangle(10, 5), new Triangle(7, 2) };
            triangleList.ForEach(triangle => triangle.WriteToFile());
        }
        public static void FileWriter(string input)
        {
            var writer = new StreamWriter(coordinates, append: true);
            writer.WriteLine(input);
            writer.Dispose();
        }
    }

}
