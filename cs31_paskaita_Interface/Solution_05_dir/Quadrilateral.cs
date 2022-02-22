using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_05_dir
{
    internal class Quadrilateral : IPolygon
    {
        // (2) Sukurkite klases Triangle, Quadrilateral, Pentagod, Hexagon ir paveldėkite IPolygon interface’ą.
        // (3) Implementuokite skaičiavimus.
        public float GetArea()
        {
            // Area of quadrilateral = (½) × diagonal length × sum of the length of the perpendiculars drawn from the remaining two vertices.
            return 0;
        }
    }
}
