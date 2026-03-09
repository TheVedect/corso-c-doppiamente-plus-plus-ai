using System;

namespace Esercizio1 {
    internal class Program{
        public static void Main(string[] args) {
            int num1 = 4;
            int num2 = 5;
            int somma  = num1 + num2;
            int sottrazione =  num1 - num2;
            int moltiplicazione = num1 * num2;
            int divisione = num1 / num2;
            Console.WriteLine("Somma: " + somma + "\nSottrazione: " + sottrazione +
                              "\nMoltiplicazione: " + moltiplicazione + "\nDivisione: " + divisione);
            
            int base_rettangolo = 5;
            int altezza_rettangolo = 7;
            int area_rettangolo =  base_rettangolo * altezza_rettangolo;
            Console.WriteLine("Area_rettangolo: " + area_rettangolo);
            
            int base_triangolo = 8;
            int altezza_triangolo = 6;
            int area_triangolo = base_triangolo * altezza_triangolo / 2;
            Console.WriteLine("Area_triangolo: " + area_triangolo);

            int raggio = 8;
            float pi = 3.14f;
            float area_cerchio = pi * raggio * raggio;
            Console.WriteLine("Area_cerchio: " + area_cerchio);
            float circonferenza = 2 * pi * raggio;
            Console.WriteLine("Circonferenza: " + circonferenza);
        }
    }
};

