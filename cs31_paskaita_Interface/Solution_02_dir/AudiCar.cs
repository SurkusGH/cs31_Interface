using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    public class AudiCar : AbstractCar
    {
        // (3) Sukurkite klasę AudiCar, kuri paveldės iš klasės Car ir turės savo property bool IsQuattro.
        public bool IsQuattro { get; set; }

        public AudiCar(bool isQuattro, string model, int fuel) : base(model, fuel)
        {
            IsQuattro = isQuattro;
        }
    }
}
