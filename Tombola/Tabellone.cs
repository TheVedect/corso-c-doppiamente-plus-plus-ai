using System;
using System.Collections.Generic;

namespace Tombola{
    public class Tabellone: Giocatore{
        private int prossima_vincita = 2;
        public int numero_tombola = 15;
        private static int I = 9;
        private static int J = 10;
        public List<int> numeri_usciti = new List<int>();

        public int Prossima_vincita {
            get {
                return prossima_vincita;
            }
            set {
                prossima_vincita = value;
            }
        }

        public void AggiornaVincita() {
            if (prossima_vincita == 5) {
                Console.WriteLine("SI VA PER LA TOMBOLA!");
                prossima_vincita = 15;
            }
            else {
                prossima_vincita++;
                Console.WriteLine("SI VA PER LA " + prossima_vincita);
            }
        }

        public Tabellone(string nome, int N) : base() {
            nome_giocatore = nome;
            for (int i = 0; i < N; i++) {
                Cartella cartella = new Cartella(i);
                cartelle.Add(cartella);
            }
        }

        public void VisualizzaTabellone() {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 5; j++) {
                    if (cartelle[0].cartella[i,j] == -1) {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"[{cartelle[0].cartella_iniziale[i,j],2}] ");
                        Console.ResetColor();
                    }else {
                        Console.Write($"[{cartelle[0].cartella[i,j],2}] ");
                    }
                    if (cartelle[3].cartella[i,j] == -1) {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"[{cartelle[3].cartella_iniziale[i,j],2}] ");
                        Console.ResetColor();
                    }else {
                        Console.Write($"[{cartelle[3].cartella[i,j],2}] ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 5; j++) {
                    if (cartelle[1].cartella[i,j] == -1) {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"[{cartelle[1].cartella_iniziale[i,j],2}] ");
                        Console.ResetColor();
                    }else {
                        Console.Write($"[{cartelle[1].cartella[i,j],2}] ");
                    }
                    if (cartelle[4].cartella[i,j] == -1) {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"[{cartelle[4].cartella_iniziale[i,j],2}] ");
                        Console.ResetColor();
                    }else {
                        Console.Write($"[{cartelle[4].cartella[i,j],2}] ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 5; j++) {
                    if (cartelle[2].cartella[i,j] == -1) {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"[{cartelle[2].cartella_iniziale[i,j],2}] ");
                        Console.ResetColor();
                    }else {
                        Console.Write($"[{cartelle[2].cartella[i,j],2}] ");
                    }
                    if (cartelle[5].cartella[i,j] == -1) {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write($"[{cartelle[5].cartella_iniziale[i,j],2}] ");
                        Console.ResetColor();
                    }else {
                        Console.Write($"[{cartelle[5].cartella[i,j],2}] ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int PescaNumero() {
            Random rnd = new Random();
            int a;
            while (true) {
                a = rnd.Next(1, 91);
                if (!numeri_usciti.Contains(a)) {
                    numeri_usciti.Add(a);
                    break;
                }
            }
            Console.WriteLine("Numero uscito: " + a);
            return a;
        }

        public void VisualizzaUsciti() {
            Console.Write("Numeri usciti: ");
            foreach (int numero in numeri_usciti) {
                Console.Write(numero + " ");
            }
        }
    }
}

