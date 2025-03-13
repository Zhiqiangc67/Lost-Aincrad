using System;
using System.Threading;
using Lost_Aincrad.Game;

namespace Lost_Aincrad
{
    // GameMenu erbt von GameBase
    internal class GameMenu : GameBase
    {
        public static void Main() {
        GameMenu gm = new GameMenu("ich", "du");
            gm.Start();
        }
        // Konstruktor, der die Parameter an die Basisklasse weitergibt
        public GameMenu(string spielerName, string spielerKlasse) : base(spielerName, spielerKlasse)
        {
        }

        public void Start()
        {
            // Begrüßung und Titel
            Console.Title = "𝑳𝑶𝑺𝑻 𝑨𝑰𝑵𝑪𝑹𝑨𝑫";
            Console.WriteLine("Willkommen in Lost Aincrad!");
            Thread.Sleep(2000);
            Console.Clear();

            // Spielername abfragen
            Console.Write("Wie lautet Ihr Name? ");
            SpielerName = Console.ReadLine()?.Trim();
            Console.Clear();

            Console.WriteLine($"Oh, Ihr Name lautet {SpielerName}, wie schön!");
            Thread.Sleep(2000);

            // Klassenwahl
            WähleKlasse();

            // Bereit-Abfrage
            BereitFrage();

            // Begrüßungsmethode der Basisklasse aufrufen
            Begrüßung();
        }

        private void WähleKlasse()
        {
            string[] klassenListe = { "Assassine", "Berserker", "Neko" };
            Random random = new Random();
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Clear();
                Console.WriteLine("Wählen Sie Ihre Klasse =^._.^=");
                Console.WriteLine("Assassine | Berserker | Neko | Zufall");

                SpielerKlasse = Console.ReadLine()?.Trim();

                if (SpielerKlasse?.ToLower() == "zufall")
                {
                    SpielerKlasse = klassenListe[random.Next(klassenListe.Length)];
                    Console.WriteLine($"Die zufällig gewählte Klasse ist: {SpielerKlasse}");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                if (Array.Exists(klassenListe, k => k.Equals(SpielerKlasse, StringComparison.OrdinalIgnoreCase)))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte erneut wählen.");
                    Thread.Sleep(2000);
                }
            }
        }

        private void BereitFrage()
        {
            bool bereitIstValid = false;

            while (!bereitIstValid)
            {
                Console.Clear();
                Console.WriteLine("Sind Sie bereit für die Welt von Aincrad? (Ja/Nein)");

                string bereit = Console.ReadLine()?.Trim().ToLower();

                if (bereit == "ja")
                {
                    Console.WriteLine("Die Reise beginnt jetzt!");
                    bereitIstValid = true;
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else if (bereit == "nein")
                {
                    Console.WriteLine("Dann bereiten Sie sich vor... Wir warten auf Sie.");
                    bereitIstValid = true;
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte antworten Sie mit 'Ja' oder 'Nein'.");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
