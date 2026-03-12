using System;
using System.Collections.Generic;

namespace Tombola{
    internal class Program{
        private static void Main(string[] args) {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next());
            Tabellone tabellone = new Tabellone();
            //tabellone.VisualizzaTabellone();
            /*
            for (int i = 0; i < 90; i++) {
                tabellone.PescaNumero();
            }
            tabellone.VisualizzaUsciti();
            */
            Cartella cartella = new Cartella();
            cartella.VisualizzaCartella();
        }
    }
};

