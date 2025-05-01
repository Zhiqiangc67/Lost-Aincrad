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
                Console.Clear();
                Console.WriteLine($"{SpielerName}, du befindest dich am Spawn von Aincrad.");
                Console.WriteLine("Wähle eine Richtung:");
                Console.WriteLine("▶ Vorwärts (W) - Verlassene Hütte");
                Console.WriteLine("▶ Rechts (D) - Brennender Wald");
                Console.WriteLine("▶ Links (A) oder Zurück (S) - Noch nicht implementiert");

                string bewegung = Console.ReadLine()?.ToUpper();

                if (bewegung == "D")
                {
                    DerBrennendeWald wald = new DerBrennendeWald(SpielerName, SpielerKlasse, HatWasserEimer);
                    wald.ZeigeBrennenderWald();
                }
                else if (bewegung == "W")
                {
                    VerlasseneHütte verlasseneHütte = new(SpielerName, SpielerKlasse);
                    VerlasseneHütte huette = verlasseneHütte;
                    huette.DieVerlassenHütte(); // Removed assignment to a bool variable since the method returns void  
                    HatWasserEimer = true; // Assuming water is always found after calling DieVerlassenHütte  
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


