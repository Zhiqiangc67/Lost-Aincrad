using Lost_Aincrad;

internal class DiddysKeller : CharacterAction
{
    private const string ForwardAction = "W";
    private const string BackAction = "S";
    private const string InventoryAction = "I";
    private const string DebugAction = "D";
    private bool _hasDisplayedVictory;

    public DiddysKeller(string spielerName, string spielerKlasse)
        : base(spielerName, spielerKlasse)
    {
        Console.WriteLine($"DEBUG: DiddysKeller instantiated for {spielerName}");
        _hasDisplayedVictory = false;
    }

    public void Lötstation()
    {
        while (true)
        {
            Console.Clear();

            // Display victory message only once when first entering
            if (!_hasDisplayedVictory)
            {
                DisplayVictoryMessage();
                _hasDisplayedVictory = true;
            }

            DisplayRoomDescription();
            DisplayAvailableActions();

            var eingabe = GetPlayerInput();

            if (ProcessInput(eingabe))
            {
                return;
            }

            Console.ReadKey();
        }
    }

    private void DisplayAvailableActions()
    {
        throw new NotImplementedException();
    }

    private object GetPlayerInput()
    {
        throw new NotImplementedException();
    }

    private bool ProcessInput(object eingabe)
    {
        throw new NotImplementedException();
    }

    private void DisplayVictoryMessage()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=== ERFOLG ===");
        Console.WriteLine("Glückwunsch! Du hast es geschafft, in Diddys Keller einzudringen!");
        Console.WriteLine("Dieser Raum birgt viele Geheimnisse...");
        Console.ResetColor();
        Console.WriteLine("\nDrücke eine Taste um fortzufahren...");
        Console.ReadKey();
    }

    private void DisplayRoomDescription()
    {
        Console.WriteLine("=== Diddys Keller ===");
        Console.WriteLine("Ein dunkler Raum voller Werkzeuge und Ersatzteile\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Der Weg nach vorne ist frei (W)");
        Console.ResetColor();
    }

    // ... rest of the existing methods remain the same ...
}