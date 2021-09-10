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

        /// <summary>
        ///   Ruft das nächste vom Benutzer gedrückte Zeichen oder die nächste Funktionstaste ab.
        ///   Die gedrückte Taste wird optional im Konsolenfenster angezeigt.
        /// </summary>
        /// <param name="abfangen">
        ///   Bestimmt, ob die gedrückte Taste im Konsolenfenster angezeigt wird. wahr, um die
        ///   gedrückte Taste nicht anzuzeigen; ansonsten falsch.
        /// </param>
        /// <returns>
        ///   Ein Objekt, das die <see cref="System.ConsoleKey"/>-Konstante und ggf.das
        ///   Unicode-Zeichen beschreibt, die der gedrückten Konsolentaste entsprechen. Das
        ///   <see cref="InformationenZuKonsolenschlüsseln"/>-Objekt beschreibt außerdem in
        ///   einer bitweisen Kombination von <see cref="System.ConsoleModifiers"/>-Werten, ob
        ///   eine oder mehrere Umschalt-, Alt- oder Strg-Modifikatortasten gleichzeitig mit der
        ///   Konsolentaste gedrückt wurden.
        /// </returns>
        /// <exception cref="System.InvalidOperationException">
        ///   Die Eigenschaft System.Console.In wird von einem anderen Strom als der Konsole
        ///   umgeleitet.
        /// </exception>
        public static InformationenZuKonsolenschlüsseln SchlüsselEinlesen(bool abfangen) => Console.ReadKey(abfangen);
    }

    /// <summary>
    /// Beschreibt die gedrückte Konsolentaste, einschließlich des durch die Konsolentaste
    /// dargestellten Zeichens und des Zustands der Modifikatortasten UMSCHALT, ALT und STRG. 
    /// </summary>
    public struct InformationenZuKonsolenschlüsseln
    {
        public InformationenZuKonsolenschlüsseln(ConsoleKeyInfo keyInfo)
        {
            Schlüssel = keyInfo.Key;
            SchlüsselZeichen = keyInfo.KeyChar;
        }
        
        public ConsoleKey Schlüssel { get; }
        public Zeichen SchlüsselZeichen { get; }

        public static implicit operator InformationenZuKonsolenschlüsseln(ConsoleKeyInfo informationenZuKonsolenschlüsseln)
            => new InformationenZuKonsolenschlüsseln(informationenZuKonsolenschlüsseln);
    }

    /// <summary>
    /// Stellt ein Zeichen als UTF-16-Einheit dar.
    /// </summary>
    public readonly struct Zeichen
    {
        private readonly char zeichen;

        public Zeichen(char zeichen)
        {
            this.zeichen = zeichen;
        }
        public static implicit operator Zeichen(char zeichen) => new Zeichen(zeichen);
        public static implicit operator char(Zeichen zeichen) => zeichen.zeichen;
    }
}
