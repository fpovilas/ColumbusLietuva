using System.Text;

namespace ColumbusLietuva
{
    internal class Program
    {
        private static Program p = new Program();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool arPasirinko = false;

            do
            {
                p.SpausdintiMenu();
                string pasirinkimas = Console.ReadLine();
                switch (pasirinkimas)
                {
                    case "1":
                        Uzduotis1 uzduotis1 = new Uzduotis1();
                        uzduotis1.Vykdyk();
                        arPasirinko = true;
                        break;
                    case "2":
                        Uzduotis2 uzduotis2 = new Uzduotis2();
                        uzduotis2.Vykdyk();
                        arPasirinko = true;
                        break;
                    case "3":
                        p.Uzduotis3();
                        arPasirinko = true;
                        break;
                    case "4":
                        p.Uzduotis4();
                        arPasirinko = true;
                        break;
                    default:
                        Console.WriteLine("Blogas pasirinkimas");
                        arPasirinko = false;
                        break;
                }
            } while(!arPasirinko);
        }

        private void Uzduotis4()
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

            foreach(char raide in sakinys)
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
                    } else { arRadauBalsi = false; }
                }
            }

            Console.WriteLine(
                $"Sakinyje: {sakinys} yra {balsiuSkaicius} " +
                $"bals{((balsiuSkaicius % 10 > 0) ? ( (balsiuSkaicius % 10 > 1) ? "ės" : "ė" ) : "ių" ) }" +
                $" ir {priebalsiuSkaicius} " +
                $"priebals{((priebalsiuSkaicius % 10 > 0) ? ((priebalsiuSkaicius % 10 > 1) ? "ės" : "ė") : "ių")}");
        }

        private void Uzduotis3()
        {
            int[] skaiciai = p.GeneruotiSkaicius(100);

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
                        if (!p.IeskotiVienodo(dubliai, skaiciai[i]))
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

        private void SpausdintiMenu()
        {
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.Write("Jūsų pasirinkimas: ");
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