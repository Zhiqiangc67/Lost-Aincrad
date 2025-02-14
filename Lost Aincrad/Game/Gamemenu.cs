using System;
using System.Globalization;
using System.Threading;

class Program
{

    static void Main()
    {
        Console.Title = ("𝑳𝑶𝑺𝑻 𝑨𝑰𝑵𝑪𝑹𝑨𝑫");

        Console.WriteLine("Willkommen in Lost Aincrad!");

        Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine("Wie Lautet ihr Name?");
        string name = Console.ReadLine();
        Console.Clear();

        Console.WriteLine($"Oh,Ihr Name Lautet {name}, wie schön!");
        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine($"Ich Skibidi Sigma, hoffe auf eine Angenehme Reise {name}!");
        Console.WriteLine("");
        Console.WriteLine("Press a Key.....");
        Console.ReadKey();
        Console.Clear();


        string[] klassenListe = { "Assassine", "Berserker", "Neko" }; // Mögliche Klassen
        string Klasse;
        bool isValidInput = false;
        Random random = new Random();

        while (!isValidInput)
        {
            Console.WriteLine("Wählen Sie Ihre Klasse =^._.^=");
            Console.WriteLine("");
            Console.WriteLine("Sie haben die Wahl zwischen:");
            Console.WriteLine("---------------------------");

            Thread.Sleep(1000);

            Console.WriteLine("Assassine");
            Thread.Sleep(1000);
            Console.WriteLine("---------");
            Console.WriteLine("Berserker");
            Thread.Sleep(1000);
            Console.WriteLine("---------");
            Console.WriteLine("Neko");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("oder");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("Zufall");
            Console.WriteLine("");

            Console.Write("Was wählen Sie? ");
            Console.WriteLine("");
            Klasse = Console.ReadLine();

            // Falls der Benutzer "Zufall" wählt, wird eine zufällige Klasse bestimmt
            if (Klasse.ToLower() == "zufall")
            {
                Klasse = klassenListe[random.Next(klassenListe.Length)];
                Console.Clear();
                Console.WriteLine($"Die zufällig gewählte Klasse ist: {Klasse}");
                Thread.Sleep(2000);
            }

            // Prüfe, ob die Eingabe gültig ist
            if (Klasse == "Assassine" || Klasse == "Berserker" || Klasse == "Neko")
            {
                Console.Clear();
                Console.WriteLine($"Sie haben {Klasse} gewählt. Sind Sie sicher? (Ja/Nein)");
                string confirmation = Console.ReadLine();

                if (confirmation.ToLower() == "ja")
                {
                    isValidInput = true;
                    Console.Clear();
                    Console.WriteLine($"Super, Sie sind ein {Klasse}!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Okay, dann wählen Sie noch einmal.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ungültige Eingabe, bitte wählen Sie eine der angegebenen Klassen.");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        Thread.Sleep(2000);

        // NEUE SCHLEIFE für die "Bereit"-Abfrage
        bool bereitIstValid = false;

        while (!bereitIstValid)
        {
            Console.WriteLine("Sind Sie bereit für die Welt von Aincrad? (Ja/Nein)");
            string bereit = Console.ReadLine().ToLower();

            if (bereit == "ja")
            {
                Console.WriteLine("Die Reise beginnt jetzt!");
                bereitIstValid = true;
            }
            else if (bereit == "nein")
            {
                Console.WriteLine("Dann bereiten Sie sich vor... Wir warten auf Sie.");
                bereitIstValid = true;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte antworten Sie mit 'Ja' oder 'Nein'.");
                Thread.Sleep(2000);
                Console.Clear();
            }

        }
    }
}