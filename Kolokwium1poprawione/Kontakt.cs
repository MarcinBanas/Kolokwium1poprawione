using System;
using System.Collections.Generic;
using System.Text;

namespace kolokwium
{
    class Kontakt
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int NrTelefonu { get; set; }
        public DateTime DataUrodzenia { get; set; }

        public Kontakt(string imie, string nazwisko, int nrtelefonu, DateTime dataurodzenia)
        {


            if ((Char.IsUpper(imie, 0) == true && Char.IsUpper(nazwisko, 0) == true) && (Convert.ToString(nrtelefonu).Length == 9) && dataurodzenia < DateTime.Now)
            {
                Imie = imie;
                Nazwisko = nazwisko;
                NrTelefonu = nrtelefonu;
                DataUrodzenia = dataurodzenia;
            }
            else
            {
                throw new ArgumentException("Bledne dane, imie oraz nazwisko powinno zaczynac sie z duzej litery, nr. tel. powinien miec 9 znakow a data ur. nie moze byc nowsza niz obecna");
            }
        }
    }
}
