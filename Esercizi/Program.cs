#define ESERCIZIO1
using System;

namespace  Esercizi {
    internal class Program{
        public static void Main(string[] args) {
            #if ESERCIZIO1
            for (int i = 10; i >= 0; i--) {
                Console.WriteLine("Numero: " + i);
            }
            #endif
        }
    }
}