using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_05_dir
{
    internal class Hexagon : IPolygon
    {
        // (2) Sukurkite klases Triangle, Quadrilateral, Pentagod, Hexagon ir paveldėkite IPolygon interface’ą.
        // (3) Implementuokite skaičiavimus.
        public float GetArea()
        {
            // The formula for the area of a hexagon is Area = (3√3 s2)/2; where 's' is the length of one side of the regular hexagon.
            // The formula for the area of a hexagon can also be given in terms of the apothem as,
            // Area of hexagon = (1/2) × a × P; where 'a' is the length of the apothem and 'P' is the perimeter of the hexagon.
            return 0;
        }
    }
}
