using System;
using System.Collections.Generic;

namespace Tombola{
    public class Tabellone{
        private static int I = 9;
        private static int J = 10;
        public int[,] tabellone = new int[I,J];
        public List<int> numeri_usciti = new List<int>();

        public Tabellone() {
            for (int i = 0; i < I; i++) {
                for (int j = 0; j < J; j++) {
                    tabellone[i, j] = i * 10 + j + 1;
                }
            }
        }

        public void VisualizzaTabellone() {
            for (int i = 0; i < I; i++) {
                for (int j = 0; j < J; j++) {
                    Console.Write(tabellone[i, j] + " ");
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

