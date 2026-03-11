#define ESERCIZIO7
using System;
using System.Collections.Generic;

namespace EserciziTerzoGiorno{
    internal  class Program{
        public static void Main(string[] args) {
            #if ESERCIZIO1
            int[] numeri1 = new int[5];
            for (int i = 0; i < numeri1.Length; i++) {
                Console.WriteLine("Prego, inserire un numero intero: ");
                numeri1[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Numeri inseriti: ");
            for (int i = 0; i < numeri1.Length; i++) {
                Console.WriteLine(numeri1[i] + " ");
            }
            #endif
            
            #if ESERCIZIO2
            int[] numeri2 = {2,6,3,5,8,4,3,5,7,8};
            int somma = 0;
            for (int i = 0; i < numeri2.Length; i++) {
                somma += numeri2[i];
            }
            Console.WriteLine("La somma è: " + somma);
            #endif
            
            #if ESERCIZIO3
            int[] numeri3 = {5, 12, 3, 20, 7, 9};
            int max = 0;
            for (int i = 0; i < numeri3.Length; i++) {
                if (numeri3[i] > max) {
                    max = numeri3[i];
                }
            }
            Console.WriteLine("Il massimo è: " + max);
            #endif
            
            #if ESERCIZIO4
            int[,] matrice1 = new int[3, 3];
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Random rnd = new Random();
                    matrice1[i, j] = rnd.Next(1, 51);
                    Console.Write(matrice1[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endif
            
            #if ESERCIZIO5
            int[,] matrice2 = new int[2, 3];
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.WriteLine("Prego, inserire l'elemento [" + i + ", " + j + "] della matrice: ");
                    matrice2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("La matrice è: ");
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write(matrice2[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endif
            
            #if ESERCIZIO6
            int N = 0;
            int M = 0;
            while (N <= 0) {
                Console.WriteLine("Prego, inserire quante righe deve avere la matrice: ");
                N = int.Parse(Console.ReadLine());
            }
            while (M <= 0) {
                Console.WriteLine("Prego, inserire quante colonne deve avere la matrice: ");
                M = int.Parse(Console.ReadLine());
            }
            int[,] matrice3 = new int[N, M];
            Console.WriteLine("La matrice è: ");
            int somma_matrice = 0;
            int[] somma_righe = new int[N];
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    Random rnd = new Random();
                    matrice3[i, j] = rnd.Next(1, 51);
                    Console.Write(matrice3[i, j] + " ");
                    somma_matrice += matrice3[i, j];
                    somma_righe[i] +=  matrice3[i, j];
                }
                Console.Write("| Somma = " + somma_righe[i]);
                Console.WriteLine();
            }
            Console.WriteLine("La somma degli elementi della matrice è: " + somma_matrice);
            int somma_diagonale1 = 0;
            int somma_diagonale2 = 0;
            if (N == M) {
                for (int i = 0; i < N; i++) {
                    somma_diagonale1 += matrice3[i, i];
                    somma_diagonale2 += matrice3[i, N - 1 - i];
                }
                Console.WriteLine("La somma diagonale 1 vale: " + somma_diagonale1);
                Console.WriteLine("La somma diagonale 2  vale: " + somma_diagonale2);
            }
            #endif

            #if ESERCIZIO7
            List<string> persone = new List<string>();
            persone.Add("John Smith");
            persone.Add("Ciccio Python");
            persone.Add("Mimmo Bello");
            

            int selettore = 0;
            string p = "";
            while (true) {
                do {
                    Console.WriteLine("Prego, inserire un numero per le operazioni:");
                    Console.WriteLine("1-Aggiungere una persona");
                    Console.WriteLine("2-Visualizzare tutti");
                    Console.WriteLine("3-Cercare per nome");
                    Console.WriteLine("4-Rimuovere una persona");
                    Console.WriteLine("0-Uscire");
                    selettore = int.Parse(Console.ReadLine());
                    switch (selettore) {
                        case 1:
                            Console.WriteLine("Prego, inserire il nome della persona da aggiungere: ");
                            p = Console.ReadLine();
                            if (persone.Contains(p)) {
                                Console.WriteLine("ERRORE! La persona è già esistente!");
                            }else {
                                persone.Add(p);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Le persone presenti sono: ");
                            foreach (string persona in persone) {
                                Console.WriteLine("-" + persona + ";");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Prego, inserire la persona da cercare: ");
                            p = Console.ReadLine();
                            if (persone.Contains(p)) {
                                Console.WriteLine("La persona" + p + " è presente;");
                            }else {
                                Console.WriteLine("La persona" + p + " non è presente;");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Prego, inserire la persona da eliminare: ");
                            p = Console.ReadLine();
                            if (persone.Contains(p)) {
                                persone.Remove(p);
                                Console.WriteLine("La persona " + p + " è stata eliminata;");
                            }else {
                                Console.WriteLine("La persona " + p + " non è presente;");
                            }
                            break;
                    }
                } while (selettore < 0 || selettore > 4);
                if (selettore == 0) {
                    Console.WriteLine("Uscita in corso....");
                    break;
                }
                Console.WriteLine();
            }
            
            #endif
        }
    }
};

