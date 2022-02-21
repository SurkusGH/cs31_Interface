using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    internal class AUDICarComparer : IComparer<AudiCar>
    {
        public int Compare(AudiCar x, AudiCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}
