using cs31_paskaita_Interface.Solution_06_dir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_05_dir
{
    public  class Triangle : IPolygon, IWriteableToFile
    {
        public float SideA { get; set; }
        public float SideB { get; set; }

        public Triangle(float sideA, float sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        // (2) Sukurkite klases Triangle, Quadrilateral, Pentagod, Hexagon ir paveldėkite IPolygon interface’ą.
        // (3) Implementuokite skaičiavimus.
        public float GetArea()
        {
            //Console.WriteLine($"Pagal formulę: ({SideA} * {SideB}) / 2 = {(SideA * SideB) / 2}");
            // Darau prezumpciją, kad trikampis status: (a*b)/2
            return (SideA * SideB) / 2;
        }

        public override string ToString()
        {
            return $"Triangle -> pagal formulę: ({SideA} * {SideB}) / 2 = {(SideA * SideB) / 2})";
        }

        public void WriteToFile() => Solution_06.FileWriter(this);
    }
}
