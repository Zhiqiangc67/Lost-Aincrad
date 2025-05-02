using System;
using Lost_Aincrad;
using Lost_Aincrad.Game;
using LOST_Aincrad__experimental_;  // Optional, wenn andere Klassen daraus verwendet werden

namespace LOST_Aincrad__experimental_
{
    internal class MiniRaum : CharacterAction
    {
        public MiniRaum(string spielerName, string spielerKlasse)
            : base(spielerName, spielerKlasse)
        {
            // Optional: Initialisierungen
        }

        public void DerMiniRaum()
        {
            Console.Clear();
            Console.WriteLine("Sie sind jetzt im MiniRaum");
            Console.ReadKey();  
            Gegner();
        }

        //private void Gegner()
       // {
          //  throw new NotImplementedException();
       // }
    }
}