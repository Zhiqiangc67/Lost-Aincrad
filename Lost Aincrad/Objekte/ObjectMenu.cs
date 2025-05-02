using Lost_Aincrad;
using Lost_Aincrad.Game;
using LOST_Aincrad__experimental_;
using LOST_Aincrad__experimental_;
using System;

namespace LOST_Aincrad__experimental_
{
    internal class ObjectMenu : GameBase
    {
        public bool HatWasserEimer { get; set; } = false; // einfacher Status  

        public ObjectMenu(string spielerName, string spielerKlasse)
            : base(spielerName, spielerKlasse)
        {
        }

        public void ZeigeOptionen(VerlasseneHütte hueette)
        {
            if (hueette is null)
            {
                throw new ArgumentNullException(nameof(hueette));
            }

            while (true)
            {
                // Console.Clear();
                Console.WriteLine($"{SpielerName}, du befindest dich am Spawn von Aincrad.");
                Console.WriteLine("Dein Ziel wird es sein,den Diddy Raum zu erreichen. hierbei warten kleine Aufgaben auf dich");
                Console.WriteLine("Wähle eine Richtung:");
                Console.WriteLine("▶ Vorwärts (W) - Verlassene Hütte");
                Console.WriteLine("▶ Rechts (D) - Brennender Wald");

                string bewegung = Console.ReadLine()?.ToUpper();
                Console.WriteLine("#### eingabe ist " + bewegung);

                if (bewegung == "D")
                {
                    Console.WriteLine("#### D ausgewählt");
                    DerBrennendeWald wald = new DerBrennendeWald(SpielerName, SpielerKlasse, HatWasserEimer);
                    wald.ZeigeBrennenderWald();
                    HatWasserEimer = true; // Assuming water is always found after calling DerBrennendeWald
                }
                else if (bewegung == "W")
                {
                    Console.WriteLine("#### W ausgewählt");
                    Verlassenehuette huette = new Verlassenehuette(SpielerName, SpielerKlasse);
                    // huette = verlasseneHütte;
                    huette.dieVerlassenehuette(); // Removed assignment to a bool variable since the method returns void  

                }
                else
                {
                    Console.WriteLine("Diese Richtung ist aktuell nicht verfügbar.");
                    Console.ReadKey();
                }
            }
        }
    }
}