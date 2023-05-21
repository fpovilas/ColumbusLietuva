namespace ColumbusLietuva
{
    internal class Program
    {
        private static Program p = new Program();
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
            string sakinysMazosiomis = sakinys.ToLower();

            char[] balsiai = {
                'a', 'ą', 'e', 'ę', 'ė', 'i',
                'į', 'y', 'o', 'u', 'ų', 'ū'};
            char[] priebalsiai = {
                'b', 'c', 'č', 'd', 'f', 'g', 'h',
                'j', 'k', 'l', 'm', 'n', 'p', 'r',
                's', 'š', 't', 'v', 'z', 'ž'};

            int balsiuSkaicius = 0;
            int priebalsiuSkaicius = 0;

            bool arRadauBalsi = false;

            foreach(char raide in sakinysMazosiomis)
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

            Console.WriteLine($"Sakinyje: {sakinys} yra {balsiuSkaicius} balsių ir {priebalsiuSkaicius} priebalsių");
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

        private void Uzduotis2()
        {
            int[] skaiciai = p.GeneruotiSkaicius(100);

            int maziausiasSkaicius = int.MaxValue;
            int didziausiasSkaicius = int.MinValue;

            Console.Write("Sugeneruotas skaičių masyvas: { ");

            for (int i = 0; i < skaiciai.Length - 1; i++)
            {
                if (i < skaiciai.Length - 2) { Console.Write($"{skaiciai[i]}, "); }
                else { Console.Write($"{skaiciai[i]} "); }

                for (int j = 0; j < skaiciai.Length - 1; j++)
                {
                    if (skaiciai[j] < skaiciai[i] && maziausiasSkaicius > skaiciai[j]) { maziausiasSkaicius = skaiciai[j]; }
                    if (skaiciai[j] > skaiciai[i] && didziausiasSkaicius < skaiciai[j]) { didziausiasSkaicius = skaiciai[j]; }
                }
            }

            Console.WriteLine("}");
            Console.WriteLine($"\nDidžiausias skaičius: {didziausiasSkaicius}. Mažiausias skaičius: {maziausiasSkaicius}.");
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