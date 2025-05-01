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

        public void DerGarten()
        {
            Console.Clear();
            Console.WriteLine("Willkommen im Garten");
            Console.WriteLine("Sie können hier Wasser holen wenn Sie einen Eimer besitzen"); //Eimer findet man in Diddys Keller
            Console.WriteLine("Sie können nur geradeaus gehen 'W'");
            string Richtung = Console.ReadLine();
            if (Richtung == "W")
            {
                Console.WriteLine("Sie gehen jetzt gerade aus 'W'");


            }

            
        }
    }
}