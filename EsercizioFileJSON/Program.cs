using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Studente {
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Eta { get; set; }
}


class Program {
    static void Main() {
        string basePath = AppContext.BaseDirectory;
        string path = Path.Combine(basePath, "NewFile1.json");
        Console.WriteLine("1 Inserisci");
        Console.WriteLine("2 Visualizza");
        Console.WriteLine("3 Aggiorna");
        Console.WriteLine("4 Elimina");
        int scelta = int.Parse(Console.ReadLine());
        List<Studente> studenti = new List<Studente>();
        if (File.Exists(path)) {
            string json = File.ReadAllText(path);
            studenti = JsonSerializer.Deserialize<List<Studente>>(json);
        }
        switch (scelta) {
            // CREATE
            case 1:
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Cognome: ");
                string cognome = Console.ReadLine();
                Console.Write("Eta: ");
                int eta = int.Parse(Console.ReadLine());
                
                 studenti.Add(new Studente{
                    Nome = nome,
                    Cognome = cognome,
                    Eta = eta
                });
                
                File.WriteAllText(path, JsonSerializer.Serialize(studenti));
                Console.WriteLine("Studente inserito");
                break;

            // UPDATE
            case 3:
                Console.Write("Indice riga da modificare: ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("Nuova riga (nome,cognome,eta): ");
                string nuova = Console.ReadLine();
                studenti[index].Eta = int.Parse(nuova);
                File.WriteAllText(path, JsonSerializer.Serialize(studenti));
                Console.WriteLine("Aggiornato");
                break;

            // DELETE
            case 4:
                Console.Write("Indice riga da eliminare: ");
                int delete = int.Parse(Console.ReadLine());
                studenti.RemoveAt(delete);
                File.WriteAllText(path, JsonSerializer.Serialize(studenti));
                Console.WriteLine("Eliminato");
                break;
        }
    }
}