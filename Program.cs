namespace ColumbusLietuva
{
    internal class Program
    {
        static Program p = new Program();
        static void Main(string[] args)
        {
            bool arPasirinko = false;
            do
            {
                p.SpausdintiMenu();
                string pasirinkimas = Console.ReadLine();
                switch (pasirinkimas)
                {
                    case "1":
                        p.Uzduotis1();
                        arPasirinko = true;
                        break;
                    case "2":
                        p.Uzduotis2();
                        arPasirinko = true;
                        break;
                    case "3":
                        //p.Uzduotis3();
                        arPasirinko = true;
                        break;
                    case "4":
                        //p.Uzduotis4();
                        arPasirinko = true;
                        break;
                    default:
                        Console.WriteLine("Blogas pasirinkimas");
                        arPasirinko = false;
                        break;
                }
            } while(!arPasirinko);
        }

        private void Uzduotis2()
        {
            int[] skaiciai = p.GeneruotiSkaicius(100);

            int maziausiasSkaicius = int.MaxValue;
            int didziausiasSkaicius = int.MinValue;

            for(int i = 0; i < skaiciai.Length - 1; i++)
            {
                for (int j = 0; j < skaiciai.Length - 1; j++)
                {
                    if (skaiciai[j] < skaiciai[i] && maziausiasSkaicius > skaiciai[j]) { maziausiasSkaicius = skaiciai[j]; }
                    if (skaiciai[j] > skaiciai[i] && didziausiasSkaicius < skaiciai[j]) { didziausiasSkaicius = skaiciai[j]; }
                }
            }

            Console.WriteLine($"Per for maziausiais: {maziausiasSkaicius} didziausiais: {didziausiasSkaicius}");
            Console.WriteLine($"Per built-in maziausiais: {skaiciai.Min()} didziausiais: {skaiciai.Max()}");



            //Algoritmas, kuris suranda skaičius
        }

        private void Uzduotis1()
        {
            Console.WriteLine("Įveskite žodį: ");
            string zodis = Console.ReadLine();

            for(int i = zodis.Length - 1; i >= 0; i--) { Console.Write(zodis[i]); }
        }

        private void SpausdintiMenu()
        {
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.Write("Jūsų pasirinkimas: ");
        }

        private int[] GeneruotiSkaicius(int kiekSugeneruotiSkaiciu)
        {
            Random random = new Random();
            int[] skaicius = new int[kiekSugeneruotiSkaiciu];

            for(int i=0; i<kiekSugeneruotiSkaiciu; i++)
            {
                skaicius[i] = random.Next(0, kiekSugeneruotiSkaiciu + 1);
            }

            return skaicius;
        }
    }
}