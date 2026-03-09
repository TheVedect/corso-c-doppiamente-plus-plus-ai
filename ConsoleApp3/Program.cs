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
            try {
                num1 = int.Parse(numero);
                num2 = int.Parse(altroNumero);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}