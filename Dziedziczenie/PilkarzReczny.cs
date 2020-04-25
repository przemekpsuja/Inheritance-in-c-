namespace Dziedziczenie
{
    public class PilkarzReczny : Pilkarz
    {
        public PilkarzReczny(string imie, string nazwisko, string rokUrodzenia, string pozycja, string klub) : base(imie, nazwisko, rokUrodzenia, pozycja, klub)
        {
        }

        public override void StrzelGola()
        {
            base.StrzelGola();
        }
    }
}