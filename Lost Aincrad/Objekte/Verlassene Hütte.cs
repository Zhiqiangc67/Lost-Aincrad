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
                Console.WriteLine("Z - Verlassen");

                string bewegung = Console.ReadLine()?.ToUpper();
                
                if (bewegung == "W")
                {
                    Console.WriteLine("Sie betreten die Innere Verlassene Hütte");
                    InnereVerlasseneHütte huette = new InnereVerlasseneHütte(SpielerName, SpielerKlasse);
                    // huette = verlasseneHütte;
                    huette.DieInnereVerlasseneHütte(); // Removed assignment to a bool variable since the method returns void
                }
                else if (bewegung == "L")
                {
                    Console.WriteLine("Sie gehen jetzt in den Garten");
                    DerGarten();
                }
                else
                {
                    Console.WriteLine("Du verlässt das Programm");
                    Environment.Exit(0);
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