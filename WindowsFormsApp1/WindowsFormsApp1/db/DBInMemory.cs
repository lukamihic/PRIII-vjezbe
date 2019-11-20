using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.db
{
    class DBInMemory
    {
        public static List<Korisnik> registrovaniKorisnici { get; set; }
        static DBInMemory()
        {
            registrovaniKorisnici = new List<Korisnik>();
            UcitajOsnovneKorisnike();
        }

        private static void UcitajOsnovneKorisnike()
        {
            Korisnik k1 = new Korisnik() 
            { 
                Ime = "Denis", 
                Prezime = "Music", 
                KorisnickoIme = "denis", 
                Lozinka = "denis" 
            };
            Korisnik k2 = new Korisnik()
            {
                Ime = "Jasmin",
                Prezime = "Azemovic",
                KorisnickoIme = "jasmin",
                Lozinka = "jasmin"
            };
            registrovaniKorisnici.Add(k1);
            registrovaniKorisnici.Add(k2);
        }
    }
    class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public bool Admin { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime} ({KorisnickoIme})";
        }
    }
}
