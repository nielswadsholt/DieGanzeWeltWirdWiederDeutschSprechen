using System;

namespace Ordnung
{
    /// <summary>
    /// Stellt die standardmäßigen Eingabe-, Ausgabe- und Fehlerströme für Konsolenanwendungen dar.
    /// Diese Klasse kann nicht vererbt werden.
    /// </summary>
    public static class Konsole
    {
        public static void Schreiben(string botschaft) => Console.WriteLine(botschaft);

        public static InformationenZuKonsolenschlüsseln SchlüsselEinlesen() => Console.ReadKey(true);
    }

    public struct InformationenZuKonsolenschlüsseln
    {
        public InformationenZuKonsolenschlüsseln(ConsoleKeyInfo keyInfo)
        {
            Schlüssel = keyInfo.Key;
            SchlüsselZeichen = keyInfo.KeyChar;
        }
        
        public ConsoleKey Schlüssel { get; }
        public char SchlüsselZeichen { get; set; }

        public static implicit operator InformationenZuKonsolenschlüsseln(ConsoleKeyInfo consoleKeyInfo)
            => new InformationenZuKonsolenschlüsseln(consoleKeyInfo);
    }
}
