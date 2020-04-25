using System;

namespace Dziedziczenie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Testy

            Osoba o1 = new Osoba("Jan", "Kowalski", "1988");
            o1.WypiszInfo();

            Student s1 = new Student("Paweł", "Nowak", "2001", 1, 2, 123456);
            s1.WypiszInfo();

            Pilkarz p1 = new Pilkarz("Robert", "Lewandowski", "1986", "Napastnik", "Bayern");
            p1.WypiszInfo();
            
            p1.StrzelGola();
            p1.WypiszInfo();
            
            #endregion
            
            s1.DodajOcene("PO", "25.04.2020", 5.0);
            s1.DodajOcene("Bazy danych", "25.04.2020", 3.5);
            s1.WypiszInfo();
            s1.UsunOcene("PO", "25.04.2020", 5.0);
            s1.WypiszInfo();
            s1.DodajOcene("PO", "25.04.2020", 5.0);
            s1.WypiszInfo();
            s1.UsunOceny("Bazy danych");
            s1.WypiszInfo();
            s1.DodajOcene("Bazy danych", "25.04.2020", 3.5);
            s1.WypiszInfo();
            s1.UsunOceny();
            s1.WypiszInfo();
        }
    }
}