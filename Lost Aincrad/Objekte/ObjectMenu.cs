using Lost_Aincrad;
using Lost_Aincrad.Game;

internal class ObjectMenu : GameBase
{
    // Konstruktor implementieren
    public ObjectMenu(string spielerName, string spielerKlasse) : base(spielerName, spielerKlasse)
    {
        // Zusätzliche Initialisierungen können hier vorgenommen werden
    }

    public void ZeigeOptionen()
    {
        while (true)
        {
            Console.Clear(); // Bildschirm leeren
            Console.WriteLine($"{SpielerName}, Sie befinden sich auf Ebene 1 von Aincrad.");
            Console.WriteLine("Sie haben die Option, weiterzugehen oder sich umzusehen.");
            Console.WriteLine("Rechts von Ihnen befindet sich ein merkwürdiger Busch.");
            Console.WriteLine("Möchten Sie vorwärts (W), rechts (D), links (A) oder rückwärts (S) gehen?");

            string bewegung = GetUserInput("Wählen Sie eine Richtung (W/A/S/D):").ToUpper();

            switch (bewegung)
            {
                case "W":
                    HandleVorwaerts();
                    break;
                case "D":
                    HandleRechts();
                    break;
                case "A":
                    HandleLinks();
                    break;
                case "S":
                    HandleRueckwaerts();
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte W, A, S oder D eingeben.");
                    Thread.Sleep(2000); // Kurze Pause, damit der Spieler die Fehlermeldung lesen kann
                    break;
            }

            Console.WriteLine("Möchten Sie zurück zum Hauptmenü? (Ja/Nein)");
            string zurueck = GetUserInput("").ToLower();

            if (zurueck == "ja")
            {
                ZurueckZumHauptmenue();
                break; // Zurück zum Hauptmenü
            }
        }
    }

    private void HandleVorwaerts()
    {
        Console.Clear(); // Bildschirm leeren
        Console.WriteLine("Sie gehen vorwärts und treffen auf eine alte Ruine...");
        HandleRuine();
    }

    private void HandleRechts()
    {
        Console.Clear(); // Bildschirm leeren
        Console.WriteLine("Sie gehen nach rechts und finden einen Schatz.");
        HandleSchatz();
    }

    private void HandleLinks()
    {
        Console.Clear(); // Bildschirm leeren
        Console.WriteLine("Sie gehen nach links und entdecken einen versteckten Pfad.");
        Console.WriteLine("Der Pfad führt zu einem geheimen Lager.");
        Console.WriteLine("Möchten Sie das Lager betreten? (Ja/Nein)");
        string lager = GetUserInput("").ToLower();

        if (lager == "ja")
        {
            Console.Clear(); // Bildschirm leeren
            Console.WriteLine("Sie betreten das Lager und finden wertvolle Ressourcen.");
        }
        else
        {
            Console.Clear(); // Bildschirm leeren
            Console.WriteLine("Sie entscheiden sich dagegen und gehen zurück.");
        }
        Thread.Sleep(2000); // Kurze Pause, damit der Spieler die Ausgabe lesen kann
    }

    private void HandleRueckwaerts()
    {
        Console.Clear(); // Bildschirm leeren
        Console.WriteLine("Sie gehen rückwärts und kehren zum Ausgangspunkt zurück.");
        Thread.Sleep(2000); // Kurze Pause, damit der Spieler die Ausgabe lesen kann
    }

    private void HandleRuine()
    {
        Console.Clear(); // Bildschirm leeren
        Console.WriteLine("Sie befinden sich vor einer alten Ruine...");
        string ruine = GetUserInput("Möchten Sie die Ruine betreten? (Ja/Nein)").ToLower();

        if (ruine == "ja")
        {
            Console.Clear(); // Bildschirm leeren
            Console.WriteLine("Sie betreten die Ruine und finden eine Schatztruhe.");
        }
        else if (ruine == "nein")
        {
            Console.Clear(); // Bildschirm leeren
            Console.WriteLine("Sie entscheiden sich dagegen und gehen zurück.");
        }
        else
        {
            Console.Clear(); // Bildschirm leeren
            Console.WriteLine("Ungültige Eingabe. Bitte Ja oder Nein eingeben.");
        }
        Thread.Sleep(2000); // Kurze Pause, damit der Spieler die Ausgabe lesen kann
    }

    private void HandleSchatz()
    {
        Console.Clear(); // Bildschirm leeren
        Console.WriteLine("Sie finden eine Schatztruhe und öffnen sie.");
        Console.WriteLine("Sie finden eine Karte und ein Schwert.");
        string option = GetUserInput("Was möchten Sie tun? (Karte/Schwert)").ToLower();

        if (option == "karte")
        {
            Console.Clear(); // Bildschirm leeren
            Console.WriteLine("Sie lesen die Karte und finden einen geheimen Pfad.");
        }
        else if (option == "schwert")
        {
            Console.Clear(); // Bildschirm leeren
            Console.WriteLine("Sie nehmen das Schwert und fühlen sich stärker.");
        }
        else
        {
            Console.Clear(); // Bildschirm leeren
            Console.WriteLine("Ungültige Eingabe. Bitte Karte oder Schwert eingeben.");
        }
        Thread.Sleep(2000); // Kurze Pause, damit der Spieler die Ausgabe lesen kann
    }

    private void ZurueckZumHauptmenue()
    {
        Console.Clear(); // Bildschirm leeren
        Console.WriteLine("Sie kehren zum Hauptmenü zurück.");
        Thread.Sleep(2000); // Kurze Pause, damit der Spieler die Ausgabe lesen kann
        // Hier könntest du das Hauptmenü aufrufen, falls es eine separate Methode gibt.
    }

    private string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine()?.Trim();
        return input ?? string.Empty;
    }
}