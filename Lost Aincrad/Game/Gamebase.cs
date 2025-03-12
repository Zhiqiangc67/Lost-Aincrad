using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_Aincrad.Game
{
     
    
        // Gemeinsame Basis-Klasse
        public class GameBase
        {
            public string SpielerName { get; set; }
            public string SpielerKlasse { get; set; }

            public void Begrüßung()
            {
                Console.WriteLine($"Willkommen, {SpielerName}! Deine Klasse ist {SpielerKlasse}.");
            }
        }
   
}
