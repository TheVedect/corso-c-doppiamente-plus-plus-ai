using System;

namespace ConsoleApp4 {
    internal class Program{
        public static void Main(string[] args) {
            int numero;
            Console.WriteLine("Inserisci un numero da 1 a 3: ");
            numero = Convert.ToInt32(Console.ReadLine());
            switch (numero) {
                case 1:
                    Console.WriteLine("Hai scelto il numero 1.");
                    break;
                case 2:
                    Console.WriteLine("Hai scelto il numero 2.");
                    break;
                case 3:
                    Console.WriteLine("Hai scelto il numero 3.");
                    break;
                default:
                    Console.WriteLine("Hai sbagliato.");
                    break;
            }
        }
    }
};