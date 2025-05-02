using System;

namespace LOST_Aincrad__experimental_
{
    internal class Malaga : ObjectMenu
    {
        public Malaga(string spielerName, string spielerKlasse)
            : base(spielerName, spielerKlasse)
        {
        }

        public void BetrittMalaga()
        {
            Console.Clear();
            Console.WriteLine(" Willkommen in Malaga..");
        }
    }
}