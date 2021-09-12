using BenutzerdefinierteErweiterungen;
using Ordnung;

namespace DieGanzeWeltWirdWiederDeutschSprechen
{   
    class Programm
    {
        static void Main(string[] args)
        {
            var schlüsselInfo = Konsole.SchlüsselEinlesen(BooleschenWert.Falsch);
            Konsole.Schreiben(schlüsselInfo.SchlüsselZeichen.ZumZeichenfolge());
            var schlüssel = Konsole.SchlüsselEinlesen().Schlüssel;
            Konsole.Schreiben(schlüssel.ZumZeichenfolge());
        }
    }
}
