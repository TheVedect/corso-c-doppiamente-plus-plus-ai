#define ESERCIZIO1
using System;
using System.Collections.Generic;
using System.Formats.Asn1;

namespace EserciziGiorno4 {
    internal class Program{

        public static void Saluta() {
            Console.WriteLine("Ciao!");
        }

        public static void StampaNumero(int numero) {
            Console.WriteLine("Stampa numero: " + numero);
        }
        public static void StampaNumero(double numero) {
            Console.WriteLine("Stampa numero: " + numero);
        }
        

        class Calcolatrice{
            public int somma(int numero1, int numero2) {
                return numero1 + numero2;
            }

            public int sottrazione(int numero1, int numero2) {
                return numero1 - numero2;
            }

            public int moltiplicazione(int numero1, int numero2) {
                return numero1 * numero2;
            }

            public int divisione(int numero1, int numero2) {
                return numero1 / numero2;
            }
        }

        class Persona(){
            public string nome;
            public int eta;

            public void Presentati() {
                Console.WriteLine("Ciao, mi chiamo " + nome + " ed ho " + eta + " anni.");
            }
        }

        public static void Raddoppia(ref int numero) {
            numero *= 2;
        }

        public static void Calcola(int numero1, int numero2, out int somma, out int differenza) {
            somma = numero1 + numero2;
            differenza = numero1 - numero2;
        }

        public static int Area(int lato) {
            return lato * lato;
        }

        public static int Area(int bass, int altezza) {
            return bass * altezza;
        }

        public static double Area(double raggio) {
            return raggio * raggio * 3.1415;
        }

        public static void LeggiNumero(out int numero) {
            Console.WriteLine("Ciao, inserisci un numero: ");
            numero = int.Parse(Console.ReadLine());
        }

        public static int Somma(int numero1, int numero2) {
            return numero1 + numero2;
        }

        public static double Media(int numero1, int numero2, int numero3) {
            return (double)(numero1 + numero2 + numero3) / 3;
        }

        public static int Maggiore(int numero1, int numero2, int numero3) {
            if (numero1 > numero2 && numero1 > numero3) {
                return numero1;
            }

            if (numero2 > numero3 && numero2 > numero3) {
                return numero2;
            }

            if (numero3 > numero1 && numero3 > numero1) {
                return numero3;
            }
            return -1;
        }
        
        public static void Main(string[] args) {
            #if ESERCIZIO1
            Saluta();
            StampaNumero(10);
            Persona p1 = new Persona();
            p1.nome = "John Cena";
            p1.eta = 10;
            p1.Presentati();
            int numero1 = 5;
            Raddoppia(ref numero1);
            StampaNumero(numero1);
            int n1 = 5;
            int n2 = 7;
            int s;
            int d;
            Calcola(n1, n2, out s, out d);
            StampaNumero(s);
            StampaNumero(d);
            int bass = 5;
            int altezza = 7;
            int lato = 9;
            double raggio = 8;
            int area_quadrato = Area(lato);
            int area_rettangolo = Area(bass, altezza);
            double area_cerchio = Area(raggio);
            StampaNumero(area_quadrato);
            StampaNumero(area_rettangolo);
            StampaNumero(area_cerchio);
            int d1;
            int d2;
            int d3;
            LeggiNumero(out d1);
            LeggiNumero(out d2);
            LeggiNumero(out d3);
            int sommmma = Somma(d1, Somma(d2, d3));
            StampaNumero(sommmma);
            double media = Media(d1, d2, d3);
            StampaNumero(media);
            int massimo = Maggiore(d1, d2, d3);
            StampaNumero(massimo);
            #endif
        }
    }
};

