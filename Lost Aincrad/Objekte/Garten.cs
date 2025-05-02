using System;
using LOST_Aincrad__experimental_;

namespace LOST_Aincrad__experimental_
{
    internal class Garten : VerlasseneHütte
    {
        private bool hatEimer = false; // Neues Feld für Eimer-Status

        public Garten(string spielerName, string spielerKlasse)
            : base(spielerName, spielerKlasse)
        {
            SpielerName = spielerName;
            SpielerKlasse = spielerKlasse;
        }

        public string SpielerName { get; }
        public string SpielerKlasse { get; }

        public void DerGarten()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Willkommen im Garten ===");
                Console.WriteLine("\nWas möchtest du tun?");

                // Verfügbare Aktionen anzeigen
                Console.WriteLine("W - Vorwärts gehen");
                if (hatEimer) Console.WriteLine("E - Wasser holen");
                Console.WriteLine("S - Zurück zur Hütte");
                Console.WriteLine("Q - Sofort verlassen");
                Console.WriteLine("I - Inventar anzeigen");

                Console.Write("\nAuswahl: ");
                var eingabe = Console.ReadLine()?.ToUpper();

                switch (eingabe)
                {
                    case "W":
                        Console.WriteLine("\nDu gehst vorwärts...");
                        new MiniRaum(SpielerName, SpielerKlasse).DerMiniRaum();
                        return;

                    case "E" when hatEimer:
                        Console.WriteLine("\nDu füllst den Eimer mit Wasser.");
                        Console.WriteLine("+ Wassereimer erhalten!");
                        // Hier könnte man ein Wassereimer-Item hinzufügen
                        Console.ReadKey();
                        break;

                    case "E":
                        Console.WriteLine("\n[!] Du benötigst einen Eimer!");
                        Console.WriteLine("Finde einen Eimer im Keller.");
                        Console.ReadKey();
                        break;

                    case "S":
                    case "Q":
                        Console.WriteLine("\nDu verlässt den Garten...");
                        dieVerlassenehuette();
                        return;

                    case "I":
                        Console.WriteLine("\n=== Dein Inventar ===");
                        Console.WriteLine(hatEimer ? "[✓] Eimer" : "[✗] Kein Eimer");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("\nUngültige Eingabe! Bitte versuche es erneut.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Methode um Eimer-Status zu setzen (kann von anderen Klassen aufgerufen werden)
        public void SetEimerStatus(bool status)
        {
            hatEimer = status;
        }
    }
}