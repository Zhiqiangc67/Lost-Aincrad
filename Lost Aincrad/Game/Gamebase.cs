﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_Aincrad.Game
{


    // Gemeinsame Basis-Klasse
    public class GameBase
    {

        private bool hatschluessel = V; // Explizite Initialisierung
        protected string SpielerName { get; set; }
        protected string SpielerKlasse { get; set; }
        public static bool V { get; private set; }

        public GameBase(string spielerName, string spielerKlasse)
        {
            SpielerName = spielerName;
            SpielerKlasse = spielerKlasse;
        }

        public GameBase()
        {
        }

        public void Begrüßung()
        {
            Console.WriteLine($"Willkommen, {SpielerName}! Deine Klasse ist {SpielerKlasse}.");
        }
    }

}