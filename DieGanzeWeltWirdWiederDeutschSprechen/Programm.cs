﻿using BenutzerdefinierteErweiterungen;
using Ordnung;

namespace DieGanzeWeltWirdWiederDeutschSprechen
{
    class Programm
    {
        static void Main(string[] args)
        {
            var schlüsselInfo = Konsole.SchlüsselEinlesen(true);

            Konsole.Schreiben(schlüsselInfo.SchlüsselZeichen.ZumZeichenfolge());
        }
    }
}
