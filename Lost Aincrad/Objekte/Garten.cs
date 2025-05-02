using System;
using LOST_Aincrad__experimental_;  // Optional, wenn andere Klassen daraus verwendet werden

namespace LOST_Aincrad__experimental_
{
    internal class Garten : VerlasseneHütte
    {
        public Garten(string spielerName, string spielerKlasse)
            : base(spielerName, spielerKlasse)
        {
            // Optional: Initialisierungen
        }

        public string SpielerName { get; private set; }
        public string SpielerKlasse { get; private set; }

        public void DerGarten()
        {
            Console.Clear();
            Console.WriteLine("Willkommen im Garten");
            Console.WriteLine("Sie können hier Wasser holen wenn Sie einen Eimer besitzen 'E' "); //Eimer findet man in Diddys Keller
            Console.WriteLine("Sie können geradeaus gehen 'W'");
            Console.WriteLine("Sie können zurück in die Verlassene Hütte gehen 'S'");
            string Richtung = Console.ReadLine();
            if (Richtung == "W")
            {
                Console.WriteLine("Sie gehen jetzt gerade aus 'W'");
                MiniRaum raum = new MiniRaum(SpielerName, SpielerKlasse);
                // huette = verlasseneHütte;
                raum.DerMiniRaum(); // Removed assignment to a bool variable since the method returns void


            }
            else if (Richtung == "E")
            {
                // wenn man item eimer hat dann bekommt man das item wassereimer
            }
            else if (Richtung == "S")
            {
                Console.WriteLine("Sie gehen jetzt zurück 'S'");
                dieVerlassenehuette();
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte versuchen Sie es erneut.");
                Console.ReadKey();
            }

            
        }
    }
}