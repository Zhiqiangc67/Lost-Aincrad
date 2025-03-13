using System;
using System.Threading;
using Lost_Aincrad.Game;

namespace Lost_Aincrad
{
    public class CharacterAction : GameBase
    {
        // Konstruktor übernimmt den Namen und die Klasse vom Spieler
        public CharacterAction(string spielerName, string spielerKlasse) : base(spielerName, spielerKlasse)
        {
        }

        public void Gegner()
        {
            Console.WriteLine("Sie treffen auf einen Gegner.");
            Console.Clear();
            Console.WriteLine($"Hallo {SpielerName}, ich werde Ihnen ein Rätsel stellen. Wenn Sie es lösen, dürfen Sie weitergehen. Wenn nicht, werden wir kämpfen!");
            Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Wer ist der größte Sigma in ganz Deutschland?");
            string lösung1 = Console.ReadLine();
            string sigmannat = "Sigmannat";

            if (lösung1.Trim().Equals(sigmannat, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Sie haben die Frage richtig beantwortet! Sie können weitergehen.");
            }
            else
            {
                Console.WriteLine("Sie haben die Frage falsch beantwortet. Sie müssen jetzt mit mir kämpfen!");
                Thread.Sleep(3000);

                Console.WriteLine("Wählen Sie Ihren Angriff:");
                Console.WriteLine("1. Nahkampf");
                Console.WriteLine("2. Fernkampf");
                Console.WriteLine("Was wählen Sie?");
                string auswahlAngriff = Console.ReadLine();

                if (auswahlAngriff == "1")
                {
                    Console.WriteLine("Sie greifen mit Nahkampf an!");
                }
                else if (auswahlAngriff == "2")
                {
                    Console.WriteLine("Sie greifen mit Fernkampf an!");
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Der Gegner greift Sie an!");
                }
            }
        }

        public static void Main1()
        {
            // Beispiel: Charakter erstellen und Aktion starten
            var characterAction = new CharacterAction("Spieler1", "Krieger");
            characterAction.Gegner(); // Die Methode "Gegner" wird aufgerufen
        }
    }
}
