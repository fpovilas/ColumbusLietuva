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
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.Write("Jūsų pasirinkimas: ");
        }
    }
}