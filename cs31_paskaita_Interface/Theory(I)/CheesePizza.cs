using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface
{
    public class CheesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Cheese Pizza");
        }
    }
}
