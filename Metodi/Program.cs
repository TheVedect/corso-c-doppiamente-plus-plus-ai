using System;
using System.Collections.Generic;

namespace Metodi {
    internal class Program{

        static void calcola(int a, int b, out int somma, out int prodotto) {
            somma = a + b;
            prodotto = a * b;
        }

        static void aumenta(ref int numero) {
            numero = numero + 10;
        }
        class Calcolatrice{
            public int somma(int a, int b) {
                return a + b;
            }

            public int somma(int a, int b, int c) {
                return a + b + c;
            }

            public double somma(double a, double b) {
                return a + b;
            }
        }

        class Persona{
            public string nome;
            public void Saluta() {
                Console.WriteLine("Ciao, sono " + nome + "!");
            }
        }
        
        public static void Main(string[] args) {
            Persona p1 = new Persona();
            p1.nome = "Ciccio";
            p1.Saluta();
            int numero = 7;
            aumenta(ref numero);
            Console.WriteLine(numero);
            int s;
            int p;
            calcola(10, 5, out s, out p);
            Console.WriteLine("La somma è: " + s + ", mentre il prodotto è: " + p);
            Calcolatrice c1 = new Calcolatrice();
            Console.WriteLine(c1.somma(19, 38));
            Console.WriteLine(c1.somma(20, 38, 348));
            Console.WriteLine(c1.somma(1.4, 2.5));
        }
    }
};

