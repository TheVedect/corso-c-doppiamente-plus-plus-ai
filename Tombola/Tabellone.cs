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
            for (int i = 0; i < 6; i++) {
                Cartella cartella = new Cartella(i);
                cartelle.Add(cartella);
            }
        }

        public void VisualizzaTabellone() {
            for (int i = 0; i < I; i++) {
                for (int j = 0; j < J; j++) {
                    if (i == 0) {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
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

