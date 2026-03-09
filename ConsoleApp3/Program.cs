using System;

namespace ConsoleApp3{
    internal class Program{
        public static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Inserisci un numero: ");
            string numero = Console.ReadLine();
            
            Console.WriteLine("Inserisci un altro numero: ");
            string altroNumero = Console.ReadLine();
            int num1 = 0;
            int num2 = 0;
            num1 = int.Parse(numero);
            num2 = int.Parse(altroNumero);
            int somma = num1 + num2;
            Console.WriteLine("Somma: " + somma);
            if (num1 > num2) {
                Console.WriteLine("Il primo numero è maggiore del secondo.");
            } else if (num1 < num2) {
                Console.WriteLine("Il secondo numero è maggiore del primo.");
            } else {
                Console.WriteLine("I due numeri sono uguali.");  
            }
        }
    }
}