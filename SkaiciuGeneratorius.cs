using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbusLietuva
{
    internal class SkaiciuGeneratorius
    {
        internal int[] GeneruotiSkaicius(int kiekSugeneruotiSkaiciu)
        {
            Random random = new Random();
            int[] skaicius = new int[kiekSugeneruotiSkaiciu];

            for (int i = 0; i < kiekSugeneruotiSkaiciu; i++)
            {
                skaicius[i] = random.Next(0, kiekSugeneruotiSkaiciu + 1);
            }

            return skaicius;
        }
    }
}
