#define ESERCIZIO6
using System;

namespace  Esercizi {
    internal class Program{
        public static void Main(string[] args) {
            #if ESERCIZIO1
            for (int i = 10; i >= 0; i--) {
                Console.WriteLine("Numero: " + i);
            }
            Console.WriteLine("BOOM!");
            #endif
            
            #if ESERCIZIO2
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("Numero: " + i*2);
            }
            #endif

            #if ESERCIZIO3
            for (int i = 0; i <= 10; i ++) {
                Console.WriteLine("Numero: " + i*5);
            }
            #endif
            
            #if ESERCIZIO4
            long N = 0;
            Console.WriteLine("Inserisci un numero N e ti calcolerò la somma dei primi N numeri: ");
            N = long.Parse(Console.ReadLine());
            long somma = 0;
            N = Math.Abs(N);
            for (long i = 0; i <= N; i++) {
                somma += i;
            }
            Console.WriteLine("La somma è: " + somma);
            #endif
            
            #if ESERCIZIO5
            int j = 1;
            while (j <= 20) {
                if (j % 3 == 0) {
                    Console.WriteLine(j + " è divisibile per 3");
                }

                j++;
            }
            #endif
            
            #if ESERCIZIO6
            int num = 1;
            while (num != 0) {
                Console.WriteLine("Prego, inserisci un numero, ma se metti 0 mi fermo: " + num);
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero inserito: " + num);
            }
            #endif
            
            #if ESERCIZIO7
            int numero_positivo = 0;
            while (numero_positivo >= 0) {
                Console.WriteLine("Inserire numero positivo o nullo. Se metti negativo, mi fermo: " + numero_positivo);
                numero_positivo = int.Parse(Console.ReadLine());
            }
            #endif
            
            #if ESERCIZIO8
            int sommazione = 0;
            int k = 0;
            while (k < 5) {
                Console.WriteLine("Prego, inserire un numero: ");
                sommazione += int.Parse(Console.ReadLine());
                k++;
            }
            Console.WriteLine("La somma è: " + sommazione);
            #endif
        }
    }
}