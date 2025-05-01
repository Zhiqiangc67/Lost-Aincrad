using System;
using System.Threading;
using LOST_Aincrad__experimental_;

namespace LOST_Aincrad__experimental_
{
    internal class DerBrennendeWald : ObjectMenu
    {
        private bool hatWasserEimer;

        public DerBrennendeWald(string spielerName, string spielerKlasse, bool hatWasserEimer)
            : base(spielerName, spielerKlasse)
        {
            this.hatWasserEimer = hatWasserEimer;
        }

        public void ZeigeBrennenderWald()
        {
            Console.Clear();
            Console.WriteLine("Der Wald brennt. Funken fliegen durch die Luft.");
            Console.WriteLine("Nur mit einem Eimer Wasser kannst du weitergehen.");

            if (hatWasserEimer)
            {
                Console.WriteLine("Du hast einen Eimer mit Wasser! Du löschst den Weg frei.");
                Console.WriteLine("Möchtest du geradeaus weitergehen (W) oder zurückkehren (S)?");

                string richtung = Console.ReadLine()?.ToUpper();

                if (richtung == "W")
                {
                    Console.WriteLine("Du gehst tiefer in den Wald...");
                    Thread.Sleep(2000);

                    Malaga malaga = new Malaga(SpielerName, SpielerKlasse);
                    malaga.BetrittMalaga();
                }
                else
                {
                    Console.WriteLine("Du kehrst um.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("❌ Du hast keinen Wassereimer. Kehre um und suche danach.");
                Console.ReadKey();
            }
        }
    }
}
