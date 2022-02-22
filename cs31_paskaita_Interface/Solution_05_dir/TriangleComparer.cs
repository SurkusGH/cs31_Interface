using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_05_dir
{
    internal class TriangleComparer : IComparer<Triangle>
    {
        // (4) Pabandykite implementuoti IComparable<> interfeisą pagal gautą figūros plotą.
        public int Compare(Triangle x, Triangle y)
        {
            //return string.Compare(x.GetArea().ToString(), y.GetArea().ToString()); // <- rūšiuoja tik pagal pirmą skaitmenį
            return Comparer<float>.Default.Compare(x.GetArea(), y.GetArea());
        }
    }
}
