namespace Dziedziczenie
{
    public class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie, string nazwisko, string rokUrodzenia, string pozycja, string klub) : base(imie, nazwisko, rokUrodzenia, pozycja, klub)
        {
        }

        public override void StrzelGola()
        {
            base.StrzelGola();
        }
    }
}