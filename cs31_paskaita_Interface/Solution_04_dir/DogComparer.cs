using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_04_dir
{
    public class DogComparer : IComparer<Dog>
    {
        public int Compare(Dog x, Dog y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
