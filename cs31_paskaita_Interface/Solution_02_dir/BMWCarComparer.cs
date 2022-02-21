using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    public class BMWCarComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar x, BmwCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}
