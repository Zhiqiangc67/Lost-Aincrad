using System;

namespace LOST_Aincrad__experimental_
{
    internal class AbandonedHut : ObjectMenu
    {
        private bool _hasKey = false;  // Tracks if player defeated the mini-boss

        public object PlayerName { get; private set; }

        public AbandonedHut(string playerName, string playerClass)
            : base(playerName, playerClass)
        {
        }

        public bool ExploreHut()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{PlayerName}, du stehst vor einer alten, verlassenen Hütte.");
                Console.WriteLine("\nWas möchtest du tun?");
                Console.WriteLine("W - Vorwärts gehen (Hütte betreten)");
                Console.WriteLine("L - Links zum Garten");
                Console.WriteLine("Z - Zurück zum Spawn");

                var input = Console.ReadLine()?.ToUpper();

                switch (input)
                {
                    case "L":
                        ExploreGarden();
                        break;

                    case "W":
                        if (TryEnterHut())
                        {
                            return true; // Returns if water bucket was found
                        }
                        break;

                    case "Z":
                        return false;

                    default:
                        Console.WriteLine("Ungültige Eingabe! (W/L/Z)");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private bool TryEnterHut()
        {
            if (!_hasKey)
            {
                Console.WriteLine("\nDie Tür ist verschlossen! Du benötigst einen Schlüssel.");
                Console.WriteLine("Hinweis: Besiege den Boss im Mini-Raum!");
                Console.ReadKey();
                return false;
            }

            Console.WriteLine("\nDu betrittst die dunkle Hütte...");
            // Add hut exploration logic here
            Console.WriteLine("Du findest einen Wassereimer!");
            return true;
        }

        private void ExploreGarden()
        {
            try
            {
                Console.WriteLine("\nDu betrittst den verwilderten Garten...");
                // Temporary implementation:
                Console.WriteLine("Hier wächst nichts außer Unkraut.");
                Console.ReadKey();

                // When implemented:
                // var garden = new Garden(PlayerName, PlayerClass);
                // garden.Explore();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Der Garten ist noch nicht zugänglich.");
                Console.ReadKey();
            }
        }

        public void ReceiveKey()
        {
            _hasKey = true;
            Console.WriteLine("\nDu hast den Schlüssel zur Hütte erhalten!");
        }
    }
}