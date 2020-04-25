using System;

namespace Dziedziczenie
{
    public class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie, string nazwisko, string rokUrodzenia, string pozycja, string klub) : base(imie, nazwisko, rokUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Piłkarz:");
            base.WypiszInfo();
            Console.WriteLine($"Pozycja: {this.Pozycja}, klub: {this.Klub}, liczba strzelonych goli: {this.LiczbaGoli}");
        }

        public virtual void StrzelGola()
        {
            liczbaGoli++;
            Console.WriteLine("Goool!!!");
        }

        public string Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
        }

        public string Klub
        {
            get { return klub; }
            set { klub = value; }
        }

        public int LiczbaGoli
        {
            get { return liczbaGoli; }
            set { liczbaGoli = value; }
        }
    }
}