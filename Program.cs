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
                        Uzduotis3 uzduotis3 = new Uzduotis3();
                        uzduotis3.Vykdyk();
                        arPasirinko = true;
                        break;
                    case "4":
                        Uzduotis4 uzduotis4 = new Uzduotis4();
                        uzduotis4.Vykdyk();
                        arPasirinko = true;
                        break;
                    default:
                        Console.WriteLine("Blogas pasirinkimas");
                        arPasirinko = false;
                        break;
                }
            } while(!arPasirinko);
        }

        private void SpausdintiMenu()
        {
            Console.WriteLine("Pasirinkite vieną iš užduočių:");
            Console.WriteLine("1. Algoritmas, kuris įvestą tekstinę reikšmę pateikia atbuline tvarką.");
            Console.WriteLine("2. Algoritmas, kuris skaičių masyve suranda mažiausią ir didžiausią skaičių.");
            Console.WriteLine("3. Algoritmas, kuris skaičių masyve suranda besidubliuojančius skaičius.");
            Console.WriteLine("4. Algoritmas, kuris suskaičiuoja balsių ir priebalsių skaičių tekste \x1b[1m“Programuotojo ar tiesiog bet kokio IT specialisto profesija taps vis labiau įprasta.“\x1b[0m");
            Console.Write("Jūsų pasirinkimas: ");
        }
    }
}