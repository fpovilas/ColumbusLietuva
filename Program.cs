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
                        //p.Uzduotis3();
                        Uzduotis3 uzduotis3 = new Uzduotis3();
                        uzduotis3.Vykdyk();
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

        private void SpausdintiMenu()
        {
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.Write("Jūsų pasirinkimas: ");
        }
    }
}