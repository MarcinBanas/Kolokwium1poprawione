using System;

namespace kolokwium
{

    class Program
    {
        public static void Mechanizm()
        {
            DateTime suma = new DateTime(2020, 12, 12, 0, 0, 0);
            int srednia;
            string h, m, s;
            int wyswietlenia = 0;
            do
            {


                Console.Write("Podaj czas (h,m,s):");
                h = Console.ReadLine();
                m = Console.ReadLine();
                s = Console.ReadLine();
                suma = suma.AddHours(int.Parse(h));
                suma = suma.AddMinutes(int.Parse(m));
                suma = suma.AddSeconds(int.Parse(s));
                Console.WriteLine("Ogladasz:" + suma.Hour + "h:" + suma.Minute + "m:" + suma.Second + "s");
                wyswietlenia = wyswietlenia + 1; ;
                srednia = (((suma.Hour * 60 + suma.Minute) * 60 + suma.Second) / wyswietlenia);
                Console.WriteLine("Srednia czasu na filmik:" + ((srednia / 60) / 60) + "h;" + ((srednia / 60) % 60) + "m:" + (srednia % 60) + "s");
                Console.WriteLine("Ilosc filmikow:" + wyswietlenia);
            }
            while (suma < new DateTime(2020, 12, 13, 0, 0, 0));
            Console.WriteLine("Przekroczyles dozwolony czas 23:59:59");
        }
        public static void Tablica()
        {
            double[,] tab = new double[4, 10];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = 1.5 * i + j * j + 1;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tab[i, j]); ;
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Srednia (x=0,y=3; x=2; y=2; x=3,y=9)=" + (tab[0, 3] + tab[2, 2] + tab[3, 9]) / 3);
        }
        static void Main(string[] args)
        {
            Tablica();
            Kontakt Person = new Kontakt("Marcin", "Banas", 123456789, new DateTime(2020, 8, 2));
            Mechanizm();
        }


    }
}
