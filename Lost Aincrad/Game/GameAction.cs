using System;
using System.Diagnostics.Metrics;

namespace Lost_Aincrad.GameAction
{
    internal class GameAction
    {
        public GameAction()
        {
            Console.WriteLine("In welcher Richtung wollen Sie gehen? (W/A/S/D)");

            string richtung = Console.ReadLine()?.ToUpper(); // Normalize input to uppercase

            int CounterW = 0;
            int CounterA = 0;
            int CounterD = 0;

            switch (richtung)
            {
                case "W":
                    Console.WriteLine("Sie sind nach oben gegangen.");
                    CounterW = +1;
                    break;
                case "A":
                    Console.WriteLine("Sie sind nach links gegangen.");
                    CounterA = +1;
                    break;
                case "S":
                    Console.WriteLine("Sie sind nach unten gegangen.");
                    CounterW = -1;
                    break;
                case "D":
                    Console.WriteLine("Sie sind nach rechts gegangen.");
                    CounterD = +1;
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe! Bitte W, A, S oder D eingeben.");
                    break;
            }
        }
    }
}