using System;
using System.IO;
using System.Collections.Generic;

class Program{
    static void Main() {
        
        Console.WriteLine(Directory.GetCurrentDirectory());string path = "NewFile1.txt";
        List<string> lines = new List<string>();
        if (File.Exists(path)) {
            lines.AddRange(File.ReadAllLines(path));
        }
        while (true) {
            Console.WriteLine("Seleziona l'azione da fare:");
            Console.WriteLine("1- Inserisci");
            Console.WriteLine("2- Visualizza");
            Console.WriteLine("3- Visualizza numero record");
            Console.WriteLine("4- Esci");
            int scelta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (scelta) {
                case 1:
                    Console.WriteLine("Inserire nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Inserire cognome: ");
                    string cognome = Console.ReadLine();
                    Console.WriteLine("Inserire eta: ");
                    int eta = int.Parse(Console.ReadLine());
                    lines.Add(nome + "," + cognome + "," + eta);
                    File.WriteAllLines(path, lines);
                    break;
            
                case 2:
                    Console.WriteLine("Dati:");
                    foreach (string line in lines) {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine();
                    break;
            
                case 3:
                    Console.WriteLine("Numero di record:" + lines.Count);
                    Console.WriteLine();
                    break;
            
                case 4:
                    Console.WriteLine("Uscita in corso....");
                    return;
                
                default:
                    Console.WriteLine("Scelta sbagliata, riprova!");
                    Console.WriteLine();
                    break;
            }
        }
        
    }
}