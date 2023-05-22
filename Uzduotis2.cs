using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbusLietuva
{
    internal class Uzduotis2 : SkaiciuGeneratorius
    {
        internal void Vykdyk()
        {
            int[] skaiciai = GeneruotiSkaicius(100);

            int maziausiasSkaicius = int.MaxValue;
            int didziausiasSkaicius = int.MinValue;

            Console.Write("Sugeneruotas skaičių masyvas: { ");

            for (int i = 0; i < skaiciai.Length - 1; i++)
            {
                if (i < skaiciai.Length - 2) { Console.Write($"{skaiciai[i]}, "); }
                else { Console.Write($"{skaiciai[i]} "); }

                if (maziausiasSkaicius > skaiciai[i])
                { maziausiasSkaicius = skaiciai[i]; }
                if (didziausiasSkaicius < skaiciai[i])
                { didziausiasSkaicius = skaiciai[i]; }
            }

            Console.WriteLine("}");

            Console.WriteLine($"\nDidžiausias skaičius: {didziausiasSkaicius}. Mažiausias skaičius: {maziausiasSkaicius}.");
        }
    }
}
