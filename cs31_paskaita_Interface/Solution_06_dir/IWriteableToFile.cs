using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs31_paskaita_Interface.Solution_06_dir
{
    public interface IWriteableToFile
    {
        // (1) Sukurkite interface’ą IWriteableToFile
        // (2) Jis turės metodą WriteToFile(string fileName)
        public void WriteToFile();
    }
}
