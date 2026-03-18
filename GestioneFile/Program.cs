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
        string path = "studenti.txt";
        
        /*SE JSON, DEVO FARE ANCHE QUESTO
        string basePath = AppContext.BaseDirectory;
        string json = Path.Combine(basePath, "studenti.json");
        */
        Console.WriteLine("1 Inserisci");
        Console.WriteLine("2 Visualizza");
        Console.WriteLine("3 Aggiorna");
        Console.WriteLine("4 Elimina");
        int scelta = int.Parse(Console.ReadLine());
        List<string> righe = new List<string>();
        if (File.Exists(path)) {
            /*SE JSON
            string json = File.ReadAllText(path);
            studenti = JsonSerializer.Deserialize<List<Studente>>(json);*/

            righe.AddRange(File.ReadAllLines(path));
        }
        switch (scelta) {
            // CREATE
            case 1:
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Cognome: ");
                string cognome = Console.ReadLine();
                Console.Write("Eta: ");
                string eta = Console.ReadLine();
                
                /*SE JSON
                 studenti.Add(new Studente{
                    Nome = nome,
                    Cognome = cognome,
                    Eta = eta
                });
                 */
                
                righe.Add($"{nome},{cognome},{eta}");
                File.WriteAllLines(path, righe);
                /*SE JSON
                 File.WriteAllText(path, JsonSerializer.Serialize(studenti));*/
                Console.WriteLine("Studente inserito");
                break;

            // READ
            case 2:
                foreach (string r in righe) {
                    /*SE è un CSV DEVO FARE ANCHE QUESTO
                    string[] colonne = line.Split(',');*/
                    Console.WriteLine(r);
                }
                break;

            // UPDATE
            case 3:
                Console.Write("Indice riga da modificare: ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("Nuova riga (nome,cognome,eta): ");
                string nuova = Console.ReadLine();
                righe[index] = nuova;
                File.WriteAllLines(path, righe);
                /*SE JSON
                 File.WriteAllText(path, JsonSerializer.Serialize(studenti));*/
                Console.WriteLine("Aggiornato");
                break;

            // DELETE
            case 4:
                Console.Write("Indice riga da eliminare: ");
                int delete = int.Parse(Console.ReadLine());
                righe.RemoveAt(delete);
                File.WriteAllLines(path, righe);
                Console.WriteLine("Eliminato");
                break;
        }
    }
}