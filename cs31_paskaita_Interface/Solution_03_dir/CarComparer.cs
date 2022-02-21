using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    public class CarComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            // (!) Implement iComparer interface'ą ir kitiems automobilių tipams (taip suprantu Car) 
            return string.Compare(x.Model, y.Model);
        }
    }
}
