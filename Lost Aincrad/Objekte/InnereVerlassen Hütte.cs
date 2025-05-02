using System;

namespace LOST_Aincrad__experimental_
{
    internal class InnereVerlasseneHütte : Verlassenehuette
    {
        private bool hatschluessel;
        private object SpielerName;

        public object SpielerKlasse { get; private set; }

        public InnereVerlasseneHütte(string spielerName, string spielerKlasse)
            : base(spielerName, spielerKlasse)
        {
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
                        if (VersucheKellerBetreten())
                            return;
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

        private bool VersucheKellerBetreten()
        {
            if (!hatschluessel)
            {
                Console.WriteLine("\nDie Kellertür ist mit einem massiven Vorhängeschloss gesichert.");
                Console.WriteLine("Du benötigst einen speziellen Schlüssel!");
                Lötstation();
                Console.ReadKey();
                return true;
            }

            Console.WriteLine("\nMit dem Schlüssel öffnest du das Vorhängeschloss...");
            var keller = new DiddysKeller2(SpielerName, SpielerKlasse, true);
            keller.BetreteKeller();
            return true;
        }

        private void Lötstation()
        {
           // throw new NotImplementedException();
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

        public void ErhalteKellerSchlüssel()
        {
            hatschluessel = true;
            Console.WriteLine("\n[System] Du hast Diddys Keller-Schlüssel erhalten!");
        }
    }
}