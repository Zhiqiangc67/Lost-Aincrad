using System;
using System.Threading;
using Lost_Aincrad.Game;
namespace Lost_Aincrad
{
        // Gemeinsame Basis-Klasse


    // GameMenu erbt von GameBase
    internal class GameMenu : GameBase
    {
        public void Start()
        {
            Console.Title = "𝑳𝑶𝑺𝑻 𝑨𝑰𝑵𝑪𝑹𝑨𝑫";
            Console.WriteLine("Willkommen in Lost Aincrad!");
            Thread.Sleep(2000);
            Console.Clear();

            Console.Write("Wie lautet Ihr Name? ");
            SpielerName = Console.ReadLine()?.Trim();
            Console.Clear();

            Console.WriteLine($"Oh, Ihr Name lautet {SpielerName}, wie schön!");
            Thread.Sleep(2000);

            // Klassenwahl
            string[] klassenListe = { "Assassine", "Berserker", "Neko" };
            bool isValidInput = false;
            Random random = new Random();

            while (!isValidInput)
            {
                Console.Clear();
                Console.WriteLine("Wählen Sie Ihre Klasse =^._.^=");
                Console.WriteLine("Assassine | Berserker | Neko | Zufall");

                SpielerKlasse = Console.ReadLine()?.Trim();
                if (SpielerKlasse.ToLower() == "zufall")
                {
                    SpielerKlasse = klassenListe[random.Next(klassenListe.Length)];
                    Console.WriteLine($"Die zufällig gewählte Klasse ist: {SpielerKlasse}");
                    Console.Clear();
                }

                if (Array.Exists(klassenListe, k => k == SpielerKlasse))
                {
                    isValidInput = true;

                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte erneut wählen.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                // NEUE SCHLEIFE für die "Bereit"-Abfrage
                bool bereitIstValid = false;

                while (!bereitIstValid)
                {
                    Console.WriteLine("Sind Sie bereit für die Welt von Aincrad? (Ja/Nein)");
                    string bereit = Console.ReadLine().ToLower();

                    if (bereit == "ja")
                    {
                        Console.WriteLine("Die Reise beginnt jetzt!");
                        bereitIstValid = true;
                        Console.Clear();
                    }
                    else if (bereit == "nein")
                    {
                        Console.WriteLine("Dann bereiten Sie sich vor... Wir warten auf Sie.");
                        bereitIstValid = true;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte antworten Sie mit 'Ja' oder 'Nein'.");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }

                    Begrüßung();
                }
            }
        }
    }
}
