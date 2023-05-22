using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbusLietuva
{
    internal class Uzduotis1
    {
        internal void Vykdyk()
        {
            Console.WriteLine("Įveskite žodį: ");
            string zodis = Console.ReadLine();

            for (int i = zodis.Length - 1; i >= 0; i--) { Console.Write(zodis[i]); }
        }
    }
}
