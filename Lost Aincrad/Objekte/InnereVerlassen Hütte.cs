using System;

namespace LOST_Aincrad__experimental_
{
    internal class InnereVerlassenehuette(string playerName, string playerClass) : Verlassenehuette(playerName, playerClass)
    {
        private bool _hasKey = true;  // Tracks if player defeated the mini-boss

        public object PlayerName { get; private set; }

        public bool DieInnereVerlassenehuette()

        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{PlayerName}, du stehst vor einer alten, verlassenen Hütte.");
                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("W - Vorwärts gehen (DiddysKeller)");
                Console.WriteLine("S - Zurück vor die Verlassene Hütte");
                Console.WriteLine("Z - Zurück zum Spawn");

                string bewegung = Console.ReadLine()?.ToUpper();

                if (bewegung == "W")
                {
                    // Schlüssel von Miniboss im miniraum hat
                    Console.WriteLine("Sie betreten DiddysKeller");
                    Diddyskeller huette = new Diddyskeller(SpielerName, SpielerKlasse);
                    // huette = verlasseneHütte;
                    huette.Lötstation(); // Removed assignment to a bool variable since the method returns void
                }
                else if (bewegung == "S")
                {
                    Console.WriteLine("Sie gehen jetzt zurück vor die Verlassene hütte");
                    dieVerlassenehuette();
                }
                else
                {
                    // Wenn man was falsches schreibt soll sich das wiederholen
                }

            }
        }
    }
}    
