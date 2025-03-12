using System;
using Lost_Aincrad.Game;

namespace Lost_Aincrad
{
    internal class GameAction : GameBase
    {
        public GameAction(string spielerName, string spielerKlasse)
        {
            SpielerName = spielerName;
            SpielerKlasse = spielerKlasse;
        }

        public void Bewegung()
        {
            Console.WriteLine($"Okay {SpielerName}, du kannst dich jetzt bewegen! (W/A/S/D)");

            bool weiter = true;
            while (weiter)
            {
                string richtung = GetUserInput("").ToUpper();
                switch (richtung)
                {
                    case "W": Console.WriteLine("Du gehst nach oben."); break;
                    case "A": Console.WriteLine("Du gehst nach links."); break;
                    case "S": Console.WriteLine("Du gehst nach unten."); break;
                    case "D": Console.WriteLine("Du gehst nach rechts."); break;
                    case "EXIT":
                        Console.WriteLine("Spiel beendet.");
                        weiter = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte W, A, S oder D nutzen.");
                        break;
                }
            }
        }

        private string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine()?.Trim();
            return input ?? string.Empty;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GameMenu menu = new GameMenu();
            menu.Start();

            GameAction action = new GameAction(menu.SpielerName, menu.SpielerKlasse);
            action.Bewegung();

            Console.WriteLine("Möchten Sie zurück zum Hauptmenü? (Ja/Nein)");
            string zurueck = Console.ReadLine()?.ToLower();

            if (zurueck == "ja")
            {
                Main(args); // Zurück zum Hauptmenü
            }
        }
    }
}