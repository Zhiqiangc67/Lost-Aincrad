using Lost_Aincrad.Game;
using System;
using System.Threading;

namespace Lost_Aincrad
{
    internal class CharacterAction : GameBase
    {
        private const bool V = false;
        int schaden;
        private bool hatschluessel;

        public object SpielerName { get; private set; }

        public CharacterAction(string spielerName, string spielerKlasse) : base(spielerName, spielerKlasse)
        {
        }

        public void Gegner()
        {
            Console.Clear();
            Console.WriteLine($"\n{SpielerName}, du triffst auf einen geheimnisvollen Wächter!");
            Console.ReadKey();

            // Rätsel-Challenge mit Fluchtoption
            Console.WriteLine("\nWächter: 'Beantworte mein Rätsel oder verlasse den Kampf (Q)!'");
            Console.WriteLine("Frage: Wer ist der größte Sigma in ganz Deutschland?");
            Console.Write("Deine Antwort (oder Q zum Verlassen): ");

            var antwort = Console.ReadLine()?.Trim();
            if (string.Equals(antwort, "Q", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nDu hast den Kampf verlassen.");
                Console.ReadKey();
                return;
            }

            if (string.Equals(antwort, "Sigmannat", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nWächter: 'Richtig! Du darfst weiterziehen.'");
                hatschluessel = true;
                Console.ReadKey();
                return;
            }

            // Kampfsystem mit Fluchtoption
            int spielerHP = 100;
            int gegnerHP = 75;
            var zufall = new Random();

            while (spielerHP > 0 && gegnerHP > 0)
            {
                Console.Clear();
                Console.WriteLine($"{SpielerName}: {spielerHP} HP  |  Wächter: {gegnerHP} HP\n");
                Console.WriteLine("Aktionen: 1-Nahkampf | 2-Fernkampf | Q-Verlassen");

                var eingabe = Console.ReadLine()?.ToUpper();

                if (eingabe == "Q")
                {
                    Console.WriteLine("\nDu hast den Kampf verlassen.");
                    Console.ReadKey();
                    return;
                }

                switch (eingabe)
                {
                    case "1":
                        schaden = zufall.Next(20, 31);
                        gegnerHP -= schaden;
                        Console.WriteLine($"\nNahkampfangriff! {schaden} Schaden!");
                        break;
                    case "2":
                        schaden = zufall.Next(15, 26);
                        gegnerHP -= schaden;
                        Console.WriteLine($"\nFernkampfangriff! {schaden} Schaden!");
                        break;
                    default:
                        Console.WriteLine("\nUngültige Eingabe - Runde verpasst!");
                        break;
                }

                if (gegnerHP > 0)
                {
                    schaden = zufall.Next(10, 21);
                    spielerHP -= schaden;
                    Console.WriteLine($"\nWächter greift an! {schaden} Schaden!");
                    Console.ReadKey();
                }
            }

            if (spielerHP > 0)
            {
                hatschluessel = true;
                Console.WriteLine("\nGlückwunsch! Wächter besiegt! Schlüssel erhalten!");
            }
            else
            {
                Console.WriteLine("\nNiederlage! Zurück zum Startpunkt.");
            }
            Console.ReadKey();
        }

        public virtual bool HatSchluessel()
        {
            return hatschluessel;
        }

        public void SetSchluessel(bool status)
        {
            hatschluessel = status;
        }
    }
}