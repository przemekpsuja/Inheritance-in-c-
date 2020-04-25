using System;
using System.Collections.Generic;

namespace Dziedziczenie
{
    public class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;
        private List<Ocena> oceny;

        public Student(string imie, string nazwisko, string rokUrodzenia, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, rokUrodzenia)
        {
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
            oceny = new List<Ocena>();
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Student:");
            base.WypiszInfo();
            Console.WriteLine($"Rok: {this.rok}, grupa {this.grupa}, numar indeksu: {this.nrIndeksu}");
            Console.WriteLine("Lista ocen:");
            foreach (Ocena ocena in oceny)
            {
                ocena.WypiszInfo();
            }
        }

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            oceny.Add(new Ocena(nazwaPrzedmiotu, data, wartosc));
            Console.WriteLine($"Wystawiono ocenę {wartosc} z przedmiotu {nazwaPrzedmiotu} dnia {data}");
        }

        public void WypiszOceny()
        {
            foreach (Ocena ocena in oceny)
            {
                ocena.WypiszInfo();
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            foreach (Ocena ocena in oceny)
            {
                if (ocena.NazwaPrzedmiotu.Equals(nazwaPrzedmiotu))
                {
                    ocena.WypiszInfo();
                }
            }   
        }
        
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena temp = oceny[i];
                if (temp.NazwaPrzedmiotu.Equals(nazwaPrzedmiotu) && temp.Data.Equals(data) && temp.Wartosc.Equals(wartosc))
                {
                    oceny.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine("Usunięto ocenę!");
        }

        public void UsunOceny()
        {
            oceny.Clear();
            Console.WriteLine("Usunięto wszystkie oceny!");
        }
        
        public void UsunOceny(string nazwaPrzedmiotu)
        {
            for(int i = 0; i < oceny.Count;)
            {
                if (oceny[i].NazwaPrzedmiotu.Equals(nazwaPrzedmiotu))
                {
                    oceny.Remove(oceny[i]);
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("Usunięto wszystkie oceny z przedmiotu {0}!", nazwaPrzedmiotu);
        }

        public int Rok
        {
            get { return rok; }
            set { rok = value; }
        }

        public int Grupa
        {
            get { return grupa; }
            set { grupa = value; }
        }

        public int NrIndeksu
        {
            get { return nrIndeksu; }
            set { nrIndeksu = value; }
        }
    }
}