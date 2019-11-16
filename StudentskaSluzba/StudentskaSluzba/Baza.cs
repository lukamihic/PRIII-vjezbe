using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzba
{
    static class Baza
    {
        public delegate void KorisnikSnimljen(Korisnik k);
        static public List<Korisnik> Korisnici { get; set; } = new List<Korisnik>();

        public static void On_KorisnikSnimljen(Korisnik k)
        {

        }
        static public event KorisnikSnimljen OnKorisnikSnimljen;
        public static void SnimiKorisnika(Korisnik k, Action<Korisnik>prikaz)
        {
            Korisnici.Add(k);
            prikaz(k);
        }
        static public bool Login(string username, string password)
        {
            return Korisnici.Where(x => x.Username == username && x.Password == password).Count() > 0;
        }

        public delegate void DodajUcionicu(Ucionica u);
        public static List<Ucionica> ucionice { get; set; } = new List<Ucionica>();
        public static void AddUcionica(Ucionica u)
        {
            ucionice.Add(u);
        }
    }
}
