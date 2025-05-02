using System;

namespace LOST_Aincrad__experimental_
{
    internal class Verlassenehuette(string playerName, string playerClass) : Garten(playerName, playerClass)
    {
        private bool _hasKey = true;  // Tracks if player defeated the mini-boss

        public object PlayerName { get; private set; }
        public string SpielerName { get; private set; }
        public string SpielerKlasse { get; private set; }

        public bool dieVerlassenehuette()

        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{PlayerName}, du stehst vor einer alten, verlassenen Hütte.");
                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("W - Vorwärts gehen (Hütte betreten)");
                Console.WriteLine("L - Links zum Garten");
                Console.WriteLine("Z - Zurück zum Spawn");

                string bewegung = Console.ReadLine()?.ToUpper();
                
                if (bewegung == "W")
                {
                    Console.WriteLine("Sie betreten die Innere Verlassene Hütte");
                    InnereVerlassenehuette huette = new InnereVerlassenehuette(SpielerName, SpielerKlasse);
                    // huette = verlasseneHütte;
                    huette.DieInnereVerlassenehuette(); // Removed assignment to a bool variable since the method returns void
                }
                else if (bewegung == "L")
                {
                    Console.WriteLine("Sie gehen jetzt in den Garten");
                    DerGarten();
                }
                else
                {
                    // Wenn man was falsches schreibt soll sich das wiederholen
                }

            }
        }

        private bool TryEnterHut()
        {
            throw new NotImplementedException();
            Console.WriteLine("dd");
        }

        private void ExploreGarden()
        {
            Console.WriteLine("Du gehst in den Garten.");
        }

    }
}