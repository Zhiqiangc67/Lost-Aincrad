using System;
using LOST_Aincrad__experimental_;  // Optional, wenn andere Klassen daraus verwendet werden

namespace LOST_Aincrad__experimental_
{
    internal class Diddyskeller : InnereVerlassenehuette
    {
        private bool hatschluessel;

        public Diddyskeller(string spielerName, string spielerKlasse)
            : base(spielerName, spielerKlasse)
        {
            {
                this.hatschluessel = hatschluessel;
            }
        }

        public void Lötstation()
        {
            Console.Clear();
            Console.WriteLine("Willkommen in Diddys Keller");
            Console.WriteLine("Sie können hier nur mit Schlüssel rein"); //Eimer findet man in Diddys Keller
            Console.WriteLine("Sie können nur geradeaus gehen 'W'");
            string Richtung = Console.ReadLine();

            if (Richtung == "W" & hatschluessel)
            {
                Console.WriteLine("Sie gehen jetzt gerade aus 'W'");

            }

            else
            {
                Console.WriteLine("Sie haben keinen Schlüssel");
                Console.WriteLine("Sie können nur zurück gehen 'S'");
                string zurück = Console.ReadLine();
                if (zurück == "S")
                {
                    Console.WriteLine("Sie gehen jetzt zurück 'S'");
                    Console.ReadKey();
                }
            }


        }
    }
}