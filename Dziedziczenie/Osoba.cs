using System;

namespace Dziedziczenie
{
    public class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string rokUrodzenia;

        public Osoba(string imie, string nazwisko, string rokUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine($"Imię: {this.imie}, nazwisko: {this.nazwisko}, rok urodzenia: {this.rokUrodzenia}");
        }

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public string RokUrodzenia
        {
            get { return rokUrodzenia; }
            set { rokUrodzenia = value; }
        }
    }
}