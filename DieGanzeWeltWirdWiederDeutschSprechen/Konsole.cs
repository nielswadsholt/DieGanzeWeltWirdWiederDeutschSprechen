using System;

namespace Ordnung
{
    public class Konsole
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
