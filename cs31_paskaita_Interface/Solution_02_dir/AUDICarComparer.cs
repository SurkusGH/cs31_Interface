using System.Collections.Generic;

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
