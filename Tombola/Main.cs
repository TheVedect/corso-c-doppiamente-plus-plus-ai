using System;
using System.Collections.Generic;

namespace Tombola{
    internal class Program{

        public static void ControllaVincita(List<Giocatore> giocatori, Tabellone t, out bool tombola) {
            bool premio_vinto = false;
            tombola = false;
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
            Tabellone tabellone = new Tabellone("Tabellone", 6);
            Console.WriteLine("Benvenuto al gioco della TOMBOLA!");
            Console.WriteLine("In quanti giocatori siete? ");
            int numero_giocatori = int.Parse(Console.ReadLine());
            List<Giocatore> giocatori = new List<Giocatore>();

            for (int i = 0; i < numero_giocatori; i++) {
                Console.WriteLine("Come si chiama il Giocatore numero " + (i + 1) + "?");
                string nome_giocatore = Console.ReadLine();
                Console.WriteLine("Quante cartelle ha " + nome_giocatore + "? ");
                int numero_cartelle = int.Parse(Console.ReadLine());
                Giocatore giocatore = new Giocatore(nome_giocatore, numero_cartelle);
                giocatori.Add(giocatore);
                Console.WriteLine("Queste sono le cartelle di " + nome_giocatore +":");
                foreach (Cartella cartella in giocatori[i].cartelle) {
                    cartella.VisualizzaCartella();
                    Console.WriteLine();
                }
            }
            giocatori.Add(tabellone);
            
            bool gioco_finito = false;

            while (!gioco_finito) {
                Console.Write("Prego, inserire l'azione desiderata tra quelle scelte!\n" +
                              "1-Pesca un numero;\n" +
                              "2-Pesca tutti i numeri in automatico;\n" +
                              "3-Visualizza tabellone;\n" +
                              "4-Visualizza prossima vincita disponibile;\n" +
                              "5-Visualizza schede;\n" +
                              "6-Visualizza numeri usciti.\n");
                Console.ResetColor();
                int selettore_azione = int.Parse(Console.ReadLine());
                int numero_uscito = 0;
                switch (selettore_azione) {
                    case 1:
                        numero_uscito = tabellone.PescaNumero();
                        foreach (Giocatore giocatore in giocatori) {
                            foreach (Cartella cartella in giocatore.cartelle) {
                                cartella.AggiornaCartella(numero_uscito);
                            }
                        }
                        ControllaVincita(giocatori, tabellone, out gioco_finito);
                        if (gioco_finito) {
                            Console.WriteLine("TOMBOLAAAA!");
                        }
                        break;
                    case 2:
                        while (!gioco_finito) {
                            numero_uscito = tabellone.PescaNumero();
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
                        break;
                    case 3:
                        /*
                        foreach (Cartella cartella in tabellone.cartelle) {
                            cartella.VisualizzaCartella(3, 5);
                        }
                        */
                        tabellone.VisualizzaTabellone();
                        break;
                    case 4:
                        Console.WriteLine("La prossima vincita è: " + tabellone.Prossima_vincita + ".");
                        break;
                    case 5:
                        foreach (Giocatore giocatore in giocatori) {
                            if (giocatore is not Tabellone) {
                                Console.WriteLine("Cartelle di " +  giocatore.nome_giocatore + ":");
                            }
                            foreach (Cartella cartella in giocatore.cartelle) {
                                if (giocatore is not Tabellone) {
                        
                                    cartella.VisualizzaCartella();
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        tabellone.VisualizzaUsciti();
                        break;
                    default:
                        break;
                }
                
                
            }
            
            foreach (Giocatore giocatore in giocatori) {
                Console.WriteLine("Cartelle di " +  giocatore.nome_giocatore + ":");
                foreach (Cartella cartella in giocatore.cartelle) {
                    if (giocatore is not Tabellone) {
                        
                        cartella.VisualizzaCartella();
                    }else {
                        cartella.VisualizzaCartella(3, 5);   
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            
        }
    }
};

