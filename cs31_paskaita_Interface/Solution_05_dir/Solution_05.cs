using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_05_dir
{
    internal class Solution_05
    {
        // (1) Sukurkite interface’ą IPolygon su metodu double GetArea()
        // (2) Sukurkite klases Triangle, Quadrilateral, Pentagod, Hexagon ir paveldėkite IPolygon interface’ą.
        // (3) Implementuokite skaičiavimus.
        // (4) Pabandykite implementuoti IComparable<> interfeisą pagal gautą figūros plotą.

        public static void Solution_05_TriangleRun()
        {
            var triangleList = new List<Triangle> { new Triangle(5, 2), new Triangle(1, 2), new Triangle(10, 5), new Triangle(7, 2)};
            var triangleComparer = new TriangleComparer();

            Console.WriteLine("Prieš sort:");
            triangleList.ForEach(item => Console.WriteLine(item.GetArea()));
            Console.WriteLine();

            Console.WriteLine("Po sort:");
            triangleList.Sort(triangleComparer);
            triangleList.ForEach(item => Console.WriteLine(item.GetArea()));
            Console.WriteLine();
        }
    }
}
