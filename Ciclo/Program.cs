namespace Ciclo {
    internal class Program{
        public static void Main(string[] args) {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Numero: " + i);
            }

            int j = 1;
            do {
                Console.WriteLine("Numero: " + j);
                j++;
            }while(j <= 10);

            while (true) {
                Console.WriteLine("Inserisci un numero, diverso da 0 o esco dal programma: ");
                int x = int.Parse(Console.ReadLine());
                if (x == 0) {
                    Console.WriteLine("Uscita dal programma in corso....");
                    break;
                }
                Console.WriteLine("Hai scelto il numero: " + x);
            }
        }
    }
};