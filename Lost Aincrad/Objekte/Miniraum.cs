using System;
using LOST_Aincrad__experimental_;  // Optional, wenn andere Klassen daraus verwendet werden

namespace LOST_Aincrad__experimental_
{
    internal class MiniRaum : Garten
    {
        public MiniRaum(string spielerName, string spielerKlasse)
            : base(spielerName, spielerKlasse)
        {
            // Optional: Initialisierungen
        }

        public void DerMiniRaum()
        {
            Console.WriteLine("Sie sind jetzt im MiniRaum");
            Gegner();
        }

        private void Gegner()
        {
            throw new NotImplementedException();
        }
    }
}