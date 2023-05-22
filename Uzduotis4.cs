using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbusLietuva
{
    internal class Uzduotis4
    {
        internal void Vykdyk()
        {
            string sakinys = "Programuotojo ar tiesiog bet kokio IT specialisto profesija taps vis labiau įprasta.";

            char[] balsiai = {
                'a', 'A', 'ą', 'Ą', 'e', 'E', 'ę', 'Ę',
                'ė', 'Ė', 'i', 'I', 'į', 'Į', 'y', 'Y',
                'o', 'O', 'u', 'U', 'ų', 'Ų', 'Ū', 'ū'};
            char[] priebalsiai = {
                'B', 'b', 'C', 'c', 'Č', 'č', 'D', 'd',
                'F', 'f', 'G', 'g', 'H', 'h', 'J', 'j',
                'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n',
                'P', 'p', 'R', 'r', 'S', 's', 'Š', 'š',
                'T', 't', 'V', 'v', 'Z', 'z', 'Ž', 'ž'};

            int balsiuSkaicius = 0;
            int priebalsiuSkaicius = 0;

            bool arRadauBalsi = false;

            foreach (char raide in sakinys)
            {
                if (raide == ' ' || raide == '.') { continue; }
                else
                {
                    foreach (char balsis in balsiai)
                    {
                        if (raide == balsis) { balsiuSkaicius++; arRadauBalsi = true; break; }
                    }

                    if (!arRadauBalsi)
                    {
                        foreach (char priebalsis in priebalsiai)
                        {
                            if (raide == priebalsis) { priebalsiuSkaicius++; break; }
                        }
                    }
                    else { arRadauBalsi = false; }
                }
            }

            Console.WriteLine(
                $"Sakinyje: {sakinys} yra {balsiuSkaicius} " +
                $"bals{((balsiuSkaicius % 10 > 0) ? ((balsiuSkaicius % 10 > 1) ? "ės" : "ė") : "ių")}" +
                $" ir {priebalsiuSkaicius} " +
                $"priebals{((priebalsiuSkaicius % 10 > 0) ? ((priebalsiuSkaicius % 10 > 1) ? "ės" : "ė") : "ių")}");
        }
    }
}
