using System;

namespace Arrays{
    internal  class Program{
        public static void Main(string[] args) {
            int[] numeri = { 1, 2, 3};
            int[] numeri2 = new int[3];
            for (int i = 0; i < numeri.Length; i++) {
                Console.WriteLine(numeri2[i]);
            }
            numeri2[0] = 4;
            numeri2[1] = 5;
            numeri2[2] = 6;
            for (int i = 0; i < numeri.Length; i++) {
                Console.WriteLine(numeri[i]);
            }

            foreach (int n in numeri2) {
                Console.WriteLine(n);
            }
            
            int[] numeri3 = new int[5];
            for (int i = 0; i < numeri3.Length; i++) {
                Console.WriteLine("Inserisci numero: ");
                numeri3[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(numeri3[i]);
            }
            int[] numeri4 = {5, 10, 15, 20, 25};
            int somma = 0;
            for (int i = 0; i < numeri4.Length; i++) {
                somma += numeri4[i];
            }
            Console.WriteLine("La somma è: " + somma);
            int[,] matrice = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            int[,] matrice2 = new int[2,3];
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write("Inserisci un elemento di matrice: ");
                    matrice2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            int[,] matrice3 = new int[2,2];
            Random rnd = new Random();
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    matrice3[i, j] = rnd.Next(1, 51);
                }
            }
        }
    }
};

