using System;

namespace LOST_Aincrad__experimental_
{
    internal class InnereVerlasseneHütte : Verlassenehuette
    {
        private object SpielerName;
        private bool _hasEnteredCellar;
        private int _entryAttempts = 0; // Track number of entry attempts

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
                Console.WriteLine($"{SpielerName}du bist in der dunklen Hütte.");
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
                        break;

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
            _entryAttempts++;

            if (_entryAttempts < 3)
            {
                Console.WriteLine("\nDie Kellertür gibt einen Widerstand...");
                Console.WriteLine("Irgendwas scheint sie zu blockieren.");
                Console.WriteLine("Was wohl helfen mag, alle dinge sind...");
                Console.ReadKey();
                return;
            }

            if (!_hasEnteredCellar)
            {
                Console.WriteLine("\n=== ERFOLG ===");
                Console.WriteLine("Du bist Klug! Alle guten Dinge sind 3 und somit stichst du als Sieger Hervor");
                Console.WriteLine("Glückwunsch! Du hast es in Diddys Keller geschafft!");
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