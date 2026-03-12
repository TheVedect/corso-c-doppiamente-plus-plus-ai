using System;
using System.Collections.Generic;

namespace Tombola{
    internal class Program{

        public static void ControllaVincita(Cartella[] cartelle, Tabellone t) {
            int contatore_tabellone = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 9; j++) {
                    if (t.tabellone[i, j] == -1) {
                        contatore_tabellone++;
                    }
                }

                if (contatore_tabellone == t.Prossima_vincita) {
                    t.AggiornaVincita();
                    return;
                }
            }
            foreach (Cartella cartella in cartelle) {
                int contatore = 0;
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 9; j++) {
                        if (cartella.cartella[i, j] == -1) {
                            contatore++;
                        }
                    }

                    if (contatore == t.Prossima_vincita) {
                        t.AggiornaVincita();
                    }
                }
                
            }
        }
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
            Cartella[] cartelle = new Cartella[2];
            for (int i = 0; i < cartelle.Length; i++) {
                cartelle[i] = new Cartella();
                cartelle[i].VisualizzaCartella();
                Console.WriteLine();
            }
        }
    }
};

