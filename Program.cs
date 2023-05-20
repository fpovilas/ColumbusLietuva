namespace ColumbusLietuva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool arPasirinko = false;
            do
            {
                SpausdintiMenu();
                string pasirinkimas = Console.ReadLine();
                switch (pasirinkimas)
                {
                    case "1":
                        Uzduotis1();
                        arPasirinko = true;
                        break;
                    case "2":
                        //Uzduotis2();
                        arPasirinko = true;
                        break;
                    case "3":
                        //Uzduotis3();
                        arPasirinko = true;
                        break;
                    case "4":
                        //Uzduotis4();
                        arPasirinko = true;
                        break;
                    default:
                        Console.WriteLine("Blogas pasirinkimas");
                        arPasirinko = false;
                        break;
                }
            } while(!arPasirinko);
        }

        private static void Uzduotis1()
        {
            Console.WriteLine("Įveskite žodį: ");
            string zodis = Console.ReadLine();

            for(int i = zodis.Length - 1; i >= 0; i--) { Console.Write(zodis[i]); }
        }

        private static void SpausdintiMenu()
        {
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.Write("Jūsų pasirinkimas: ");
        }
    }
}