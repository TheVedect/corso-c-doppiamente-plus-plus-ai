using System;
using System.Collections.Generic;

namespace Liste {
    internal class Program {
        public static void Main(string[] args) {
            List<int> numeri = new List<int>();
            numeri.Add(10);
            numeri.Add(1);
            numeri.Add(29);
            for (int i = 0; i < numeri.Count; i++) {
                Console.WriteLine(numeri[i]);
            }

            foreach (int i in numeri) {
                Console.WriteLine(i);
            }
            numeri.Remove(29);
            if (numeri.Contains(10)) {
                Console.WriteLine("Il numero esiste!");
            }

            List<int> numeri2 = new List<int>();
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Inserisci un numero: ");
                numeri2.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Numeri inseriti:");
            foreach (int i in numeri2) {
                Console.Write(i + " ");
            }
        }
    }
};

