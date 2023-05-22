using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbusLietuva
{
    internal class Uzduotis3 : SkaiciuGeneratorius
    {
        internal void Vykdyk()
        {
            int[] skaiciai = GeneruotiSkaicius(100);

            List<int> dubliai = new List<int>();

            Console.Write("Sugeneruotas skaičių masyvas: { ");

            for (int i = 0; i < skaiciai.Length - 1; i++)
            {
                if (i < skaiciai.Length - 2) { Console.Write($"{skaiciai[i]}, "); }
                else { Console.Write($"{skaiciai[i]} "); }

                for (int j = i + 1; j < skaiciai.Length - 1; j++)
                {
                    if (skaiciai[i] == skaiciai[j])
                    {
                        if (!IeskotiVienodo(dubliai, skaiciai[i]))
                        {
                            dubliai.Add(skaiciai[i]);
                            break;
                        }
                        else { break; }

                    }
                }
            }

            Console.WriteLine("}");
            Console.Write("\nPasikartojačių skaičių masyvas: { ");
            for (int i = 0; i < dubliai.Count; i++)
            {
                if (i < dubliai.Count - 1) { Console.Write($"{dubliai[i]}, "); }
                else { Console.Write($"{dubliai[i]} "); }
            }
            Console.WriteLine("}");

        }

        private bool IeskotiVienodo(List<int> masyvas, int ieskomasSkaicius)
        {
            bool atsakymas = false;
            if (masyvas == null) { atsakymas = false; }
            else
            {
                foreach (int i in masyvas)
                {
                    if (i == ieskomasSkaicius) { atsakymas = true; }
                    else { atsakymas = false; }
                }
            }
            return atsakymas;
        }
    }
}
