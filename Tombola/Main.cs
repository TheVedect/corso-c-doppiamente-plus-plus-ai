using System;
using System.Collections.Generic;

namespace Tombola{
    internal class Program{

        public static void ControllaVincita(Giocatore[] giocatori, Tabellone t, out bool tombola) {
            bool premio_vinto = false;
            tombola = false;
            /*
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
            */
            foreach (Giocatore giocatore in giocatori) {
                int indice_tabella = 0;
                foreach (Cartella cartella in giocatore.cartelle) {
                    indice_tabella++;
                    int contatore = 0;
                    int contatore_tombola = 0;
                    for (int i = 0; i < 3; i++) {
                        for (int j = 0; j < 9; j++) {
                            if (cartella.cartella[i, j] == -1) {
                                contatore++;
                                contatore_tombola++;
                                if (contatore == t.Prossima_vincita) {
                                    Console.WriteLine("Il giocatore " + giocatore.nome_giocatore + " ha fatto " + contatore +
                                                      " nella tabella numero " + indice_tabella + ".");
                                    premio_vinto = true;
                                    break;
                                }

                                if (contatore_tombola == t.numero_tombola) {
                                    Console.WriteLine("Il giocatore " + giocatore.nome_giocatore +
                                                      " ha fatto TOMBOLA nella tabella numero " + indice_tabella + ".");
                                    premio_vinto = true;
                                    tombola = true;
                                    break;
                                }
                            }

                        }
                        contatore = 0;
                        if (premio_vinto) {
                            break;
                        }
                    }

                    if (premio_vinto) {
                        break;
                    }
                    
                }
            }

            if (premio_vinto) {
                t.AggiornaVincita();
            }

            if (tombola) {
                return;
            }
        }
        private static void Main(string[] args) {
            Random rnd = new Random();
            Tabellone tabellone = new Tabellone();
            //tabellone.VisualizzaTabellone();
            /*
            for (int i = 0; i < 90; i++) {
                tabellone.PescaNumero();
            }
            tabellone.VisualizzaUsciti();
            Cartella[] cartelle = new Cartella[3];
            for (int i = 0; i < cartelle.Length; i++) {
                cartelle[i] = new Cartella();
                cartelle[i].VisualizzaCartella();
                Console.WriteLine();
            }
            */
            
            Console.WriteLine("Quanti giocatori? ");
            int numero_giocatori = int.Parse(Console.ReadLine());
            Giocatore[] giocatori = new Giocatore[numero_giocatori];

            for (int i = 0; i < numero_giocatori; i++) {
                Console.WriteLine("Come si chiama il Giocatore numero " + (i + 1) + "?");
                string nome_giocatore = Console.ReadLine();
                Console.WriteLine("Quante cartelle ha " + nome_giocatore + "? ");
                int numero_cartelle = int.Parse(Console.ReadLine());
                giocatori[i] = new Giocatore(nome_giocatore, numero_cartelle);
                foreach (Cartella cartella in giocatori[i].cartelle) {
                    cartella.VisualizzaCartella();
                    Console.WriteLine();
                }
            }
            
            bool gioco_finito = false;

            while (!gioco_finito) {
                int numero_uscito = tabellone.PescaNumero();
                foreach (Giocatore giocatore in giocatori) {
                    foreach (Cartella cartella in giocatore.cartelle) {
                        cartella.AggiornaCartella(numero_uscito);
                    }
                }
                ControllaVincita(giocatori, tabellone, out gioco_finito);
                if (gioco_finito) {
                    Console.WriteLine("TOMBOLAAAA!");
                }
            }
            
            foreach (Giocatore giocatore in giocatori) {
                Console.WriteLine("Cartelle di " +  giocatore.nome_giocatore + ":");
                foreach (Cartella cartella in giocatore.cartelle) {
                    cartella.VisualizzaCartella();
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            
        }
    }
};

