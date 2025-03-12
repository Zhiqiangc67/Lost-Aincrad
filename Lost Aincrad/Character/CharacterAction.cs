using Lost_Aincrad;
using System;
using Lost_Aincrad.Game;


namespace Lost_Aincrad
{


    public class CharacterAction : GameBase
    {
        public static void Gegner()
        {
            Console.WriteLine("sie treffen auf einen Gegner");
            Console.Clear();
            Console.WriteLine($"Hallo {new GameBase().SpielerName} ich werde Ihnen en Rätsel stellen, wenn Sie dieses Lösen werde ich Sie weiter lassen, wenn nicht werden Wir kämpfen");
            Console.WriteLine("Drücken Sie eine beliebige Taste");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Wer ist Der Größte Sigma in Ganz Deutschland?");
            string Lösung1 = Console.ReadLine();
            string Sigmannat = "Sigmannat";

            if (Lösung1.Trim().Equals(Sigmannat, StringComparison.OrdinalIgnoreCase))

            {
                Console.WriteLine("Sie haben die Frage richtig beantwortet, Sie können weiter gehen");
            }
            else
            {
                Console.WriteLine("Sie haben die Frage falsch beantwortet, Sie müssen jetzt mit mir kämpfen");
                Console.WriteLine("Wählen Sie Ihren Angriff");
                Thread.Sleep(3000);
                Console.WriteLine("Nahkampf");
                Thread.Sleep(3000);
                Console.WriteLine("Fernkampf");
                Console.WriteLine("Was wählen Sie?");
                string AuswahlAngriff = Console.ReadLine();
            }
        }
        public static void Main1()
        {
            Gegner(); // Die Methode "Gegner" wird aufgerufen
        }
    }
}
