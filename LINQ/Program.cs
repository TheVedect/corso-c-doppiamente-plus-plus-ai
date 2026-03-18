using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class Studente{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Eta { get; set; }
    public int Voti { get; set; }
}

public class ScuolaContext : DbContext {
    public DbSet<Studente> Studenti { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options) {
        string connStr = "server=localhost;database=scuola;user=root;password=root;";
        options.UseMySql(connStr, ServerVersion.AutoDetect(connStr));
    }
}

class Program {
    static void Main(string[] args) {
        using (var db = new ScuolaContext()) {
            Console.WriteLine("Connessione riuscita");
            // ---------------------------
            // CREATE
            // ---------------------------
            var studente = new Studente {
                Nome = "Daft",
                Cognome = "Punk",
                Eta = 21,
                Voti = 20
            };
            db.Studenti.Add(studente);
            db.SaveChanges();
            Console.WriteLine("Studente inserito");
            // ---------------------------
            // READ
            // ---------------------------
            var studenti = db.Studenti.ToList();
            Console.WriteLine("\nLista studenti:");
            foreach (var s in studenti) {
                Console.WriteLine($"{s.Id} | {s.Nome} | {s.Cognome} | {s.Eta} | {s.Voti}");
            }
            // ---------------------------
            // UPDATE
            // ---------------------------
            var studenteUpdate = db.Studenti.FirstOrDefault(s => s.Id == 2);
            if (studenteUpdate != null) {
                studenteUpdate.Eta = 30;
                db.SaveChanges();

                Console.WriteLine("\nStudente aggiornato");
            }
            // ---------------------------
            // INFOGRAFICA
            // ---------------------------
            var ordinati_secondo_nome = studenti.OrderBy(s => s.Nome);
            Console.WriteLine("ORDINATI SECONDO NOME:");
            foreach (var s in ordinati_secondo_nome) {
                Console.WriteLine($"{s.Id} | {s.Nome} | {s.Cognome} | {s.Eta} | {s.Voti}");
            }
            var ordinati_secondo_voto = studenti.OrderBy(s => s.Voti);
            Console.WriteLine("ORDINATI SECONDO VOTO:");
            foreach (var s in ordinati_secondo_voto) {
                Console.WriteLine($"{s.Id} | {s.Nome} | {s.Cognome} | {s.Eta} | {s.Voti}");
            }
            Console.WriteLine("\nLista studenti Passati:");
            foreach (var s in studenti) {
                if (s.Voti >= 18) {
                    Console.WriteLine($"{s.Id} | {s.Nome} | {s.Cognome} | {s.Eta} | {s.Voti}");
                }
            }
            Console.WriteLine();
            
            Console.WriteLine("\nLista studenti oltre 20 anni:");
            foreach (var s in studenti) {
                if (s.Eta > 20) {
                    Console.WriteLine($"{s.Id} | {s.Nome} | {s.Cognome} | {s.Eta} | {s.Voti}");
                }
            }
            Console.WriteLine("Voto massimo: " + studenti.Max(st => st.Eta));
            Console.WriteLine("Voto minimo: " + studenti.Min(st => st.Voti));
            Console.WriteLine("Media Voti: " + studenti.Average(st => st.Voti));
            
            // ---------------------------
            // DELETE
            // ---------------------------
            var studenteDelete = db.Studenti.FirstOrDefault(s => s.Id == 5);
            if (studenteDelete != null) {
                db.Studenti.Remove(studenteDelete);
                db.SaveChanges();
                Console.WriteLine("Studente eliminato");
            }
        }
        Console.WriteLine("\nOperazioni completate");
    }
}
