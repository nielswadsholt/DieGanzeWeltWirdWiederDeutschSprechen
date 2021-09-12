namespace Ordnung
{
    public readonly struct BooleschenWert
    {
        public static BooleschenWert Falsch = new BooleschenWert(false);
        public static BooleschenWert Wahr = new BooleschenWert(true);

        public BooleschenWert(bool wert)
        {
            Wert = wert;
        }

        public readonly bool Wert { get; }

        public static implicit operator BooleschenWert(bool wert) => new BooleschenWert(wert);
        public static implicit operator bool(BooleschenWert wert) => wert.Wert;
    }
}