using System;
using Lost_Aincrad.Game;
using LOST_Aincrad__experimental_;

namespace Lost_Aincrad.Objekte
{
    internal class Player : GameBase
    {
        private Ort _currentLocation;
        private Inventory _inventory;
        private int _health;
        private object spielername;
        private object spielerklasse;
        private string spielerKlasse;
        private const int MaxHealth = 100;

        public Player(string spielername, string spielerklasse, ObjectMenu startpunkt, string spielerKlasse)
            : base(spielername, spielerklasse)
        {
            _currentLocation = startpunkt;
            _health = MaxHealth;
            _inventory = new Inventory();
            this.spielerKlasse = spielerKlasse;
        }


        private void PlayTurn()
        {
            Console.WriteLine("\nWas möchtest du tun?");
            Console.WriteLine("1. Bewegen");
            Console.WriteLine("2. Inventar anzeigen");
            Console.WriteLine("3. Mit Umgebung interagieren");
            Console.WriteLine("4. Spielstatus");
            Console.WriteLine("5. Beenden");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Move();
                    break;
                case "2":
                    _inventory.Show();
                    break;
                case "3":
                    _currentLocation.Interact(this);
                    break;
                case "4":
                    ShowStatus();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }
        }

        private void Move()
        {
            Console.WriteLine("Wohin möchtest du gehen?");
            _currentLocation.ShowAvailableDirections();

            var direction = Console.ReadLine()?.ToUpper();
            var newLocation = _currentLocation.GetLocationInDirection(direction);

            if (newLocation != null)
            {
                _currentLocation = newLocation;
                Console.WriteLine(value: $"Du bist jetzt in {_currentLocation.Name}.");
                _currentLocation.OnPlayerArrived(this);
            }
            else
            {
                Console.WriteLine("Du kannst nicht in diese Richtung gehen!");
            }
        }

        public void TakeDamage(int amount)
        {
            _health -= amount;
            if (_health <= 0)
            {
                _health = 0;
                Console.WriteLine("Du bist besiegt worden!");
            }
            else
            {
                Console.WriteLine($"Du erleidest {amount} Schaden! Verbleibende HP: {_health}/{MaxHealth}");
            }
        }

        public void Heal(int amount)
        {
            _health = Math.Min(_health + amount, MaxHealth);
            Console.WriteLine($"Du wurdest um {amount} geheilt! Aktuelle HP: {_health}/{MaxHealth}");
        }

        public void AddToInventory(Item item)
        {
            _inventory.Add(item);
            Console.WriteLine($"{item.Name} wurde deinem Inventar hinzugefügt.");
        }

        private void ShowStatus()
        {
            Console.WriteLine($"\n--- Status von {spielername} ---");
            Console.WriteLine($"Klasse: {spielerklasse}");
            Console.WriteLine($"HP: {_health}/{MaxHealth}");
            Console.WriteLine($"Ort: {_currentLocation.Name}");
            Console.WriteLine("--------------------------");
        }

        private void GameOver()
        {
            Console.WriteLine("\n--- GAME OVER ---");
            Console.WriteLine("Möchtest du neu beginnen? (j/n)");
            var choice = Console.ReadLine()?.ToLower();

            if (choice == "j")
            {
                // Reset game state
                _health = MaxHealth;
                _currentLocation = new ObjectMenu(SpielerName,spielerKlasse);
                
            }
        }
    }

    public class Inventory
    {
        private List<Item> _items = new List<Item>();

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public void Show()
        {
            Console.WriteLine("\n--- Inventar ---");
            if (_items.Count == 0)
            {
                Console.WriteLine("Leer");
            }
            else
            {
                foreach (var item in _items)
                {
                    Console.WriteLine($"- {item.Name}: {item.Description}");
                }
            }
            Console.WriteLine("----------------");
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}