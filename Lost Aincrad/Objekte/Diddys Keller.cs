using Lost_Aincrad;

internal class DiddysKeller : CharacterAction
{
    private const string ForwardAction = "W";
    private const string BackAction = "S";
    private const string InventoryAction = "I";
    private const string DebugAction = "D";

    public DiddysKeller(string spielerName, string spielerKlasse)
        : base(spielerName, spielerKlasse)
    {
        Console.WriteLine($"DEBUG: DiddysKeller instantiated for {spielerName}");
    }

    public void Lötstation()
    {
        while (true)
        {
            Console.Clear();
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

    private void DisplayRoomDescription()
    {
        Console.WriteLine("=== Diddys Keller ===");
        Console.WriteLine("Ein dunkler Raum voller Werkzeuge und Ersatzteile\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Der Weg nach vorne ist frei (W)");
        Console.ResetColor();
    }

    private void DisplayAvailableActions()
    {
        Console.WriteLine("\nVerfügbare Aktionen:");
        Console.WriteLine($"{ForwardAction} - Vorwärts gehen");
        Console.WriteLine($"{BackAction} - Zurück zur Hütte");
        Console.WriteLine($"{InventoryAction} - Inventar checken");
        Console.WriteLine($"{DebugAction} - Debug-Informationen");
        Console.Write("Auswahl: ");
    }

    private string GetPlayerInput()
    {
        return Console.ReadLine()?.ToUpper() ?? string.Empty;
    }

    private bool ProcessInput(string input)
    {
        switch (input)
        {
            case ForwardAction:
                Console.WriteLine("\nDu gehst tiefer in den Keller hinein...");
                // Hier würde normalerweise der Raumübergang stattfinden
                Console.ReadKey();
                return true;

            case BackAction:
                Console.WriteLine("\nDu verlässt den Keller...");
                return true;

            case InventoryAction:
                DisplayInventory();
                return false;

            case DebugAction:
                ShowDebugInfo();
                return false;

            default:
                Console.WriteLine("\nUngültige Eingabe!");
                return false;
        }
    }

    private void DisplayInventory()
    {
        Console.WriteLine("\n=== Inventar ===");
        // Keine Schlüsselinformationen mehr
    }

    private void ShowDebugInfo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n=== DEBUG INFORMATION ===");
        Console.WriteLine($"Player: {SpielerName}");
        Console.WriteLine($"Type: {this.GetType()}");
        Console.WriteLine($"Base type: {this.GetType().BaseType}");
        Console.ResetColor();
        Console.WriteLine("Drücke eine Taste um fortzufahren...");
    }
}