using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_04_dir
{
    public class CatComparer : IComparer<Cat>
    {
        public int Compare(Cat x, Cat y)
        {
            return string.Compare(x.Weight.ToString(), y.Weight.ToString());
        }
    }
}
