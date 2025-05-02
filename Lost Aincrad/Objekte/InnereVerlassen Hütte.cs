using System;

namespace LOST_Aincrad__experimental_
{
    internal class InnereVerlasseneHütte : Verlassenehuette
    {
        private object SpielerName;
        private bool _hasEnteredCellar; // Track if player has seen cellar message

        public object SpielerKlasse { get; private set; }

        public InnereVerlasseneHütte(string spielerName, string spielerKlasse)
            : base(spielerName, spielerKlasse)
        {
            _hasEnteredCellar = false;
        }

        public void DieInnereVerlasseneHütte()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{SpielerName}, du bist in der dunklen Hütte.");
                Console.WriteLine("Modrige Luft und knarzende Dielen umgeben dich.");

                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("W - Keller betreten (Diddys Reich)");
                Console.WriteLine("U - Umsehen");
                Console.WriteLine("S - Zurück zum Hütteneingang");
                Console.WriteLine("Z - Verlassen");

                var eingabe = Console.ReadLine()?.ToUpper();

                switch (eingabe)
                {
                    case "W":
                        KellerBetreten();
                        return;

                    case "U":
                        ZeigeHüttenDetails();
                        break;

                    case "S":
                        Console.WriteLine("Du gehst zurück zum Eingang...");
                        return;

                    case "Z":
                        Console.WriteLine("Du verlässt das Programm");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe! Erneut versuchen.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void KellerBetreten()
        {
            if (!_hasEnteredCellar)
            {
                Console.WriteLine("\n=== ERFOLG ===");
                Console.WriteLine("Glückwunsch! Du hast es in Diddys Keller geschafft!");
                Console.WriteLine("Dieser Raum birgt viele Geheimnisse...");
                Console.WriteLine("\nDrücke eine Taste um fortzufahren...");
                Console.ReadKey();
                _hasEnteredCellar = true;
            }

            Console.WriteLine("\nDu öffnest die Kellertür und steigst hinab...");
            var keller = new DiddysKeller2(SpielerName, SpielerKlasse, true);
            keller.BetreteKeller();
        }

        private void Lötstation()
        {
            // Empty implementation
        }

        private void ZeigeHüttenDetails()
        {
            Console.Clear();
            Console.WriteLine("Du siehst dich um:");
            Console.WriteLine("- Eingestaubte Möbel");
            Console.WriteLine("- Zerrissene Landkarten an den Wänden");
            Console.WriteLine("- Eine funktionierende Öllampe");
            Console.WriteLine("\nDrücke eine Taste...");
            Console.ReadKey();
        }
    }
}