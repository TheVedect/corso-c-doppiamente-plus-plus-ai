using System;
using MySql.Data.MySqlClient;

class Program {
    static void Main() {
        string connStr = "server=localhost;database=musica;user=root;password=root;";
        using (MySqlConnection conn = new MySqlConnection(connStr)) {
            conn.Open();

            while (true) {
                Console.WriteLine("Decidi l'azione da fare:");
                Console.WriteLine("1- Inserisci un CD nuovo");
                Console.WriteLine("2- Visualizza i CD presenti");
                Console.WriteLine("3- Aggiorna un CD");
                Console.WriteLine("4- Elimina un CD");
                Console.WriteLine("5- Esci dal programma");
                Console.Write("Scelta: ");
                int scelta = int.Parse(Console.ReadLine());

                switch (scelta) {
                    case 1:
                        Console.Write("Titolo: ");
                        string titolo = Console.ReadLine();
                        Console.Write("Autore: ");
                        string autore = Console.ReadLine();
                        Console.Write("Genere Musicale: ");
                        string genere = Console.ReadLine();
                        Console.Write("Anno di uscita: ");
                        int anno = int.Parse(Console.ReadLine());
                        string insert = "INSERT INTO dischi (titolo,autore,genere,anno) VALUES(@titolo,@autore,@genere,@anno)";
                        MySqlCommand cmdInsert = new MySqlCommand(insert, conn);
                        cmdInsert.Parameters.AddWithValue("@titolo", titolo);
                        cmdInsert.Parameters.AddWithValue("@autore", autore);
                        cmdInsert.Parameters.AddWithValue("@genere", genere);
                        cmdInsert.Parameters.AddWithValue("@anno", anno);
                        cmdInsert.ExecuteNonQuery();
                        Console.WriteLine("CD inserito");
                        Console.WriteLine();
                        break;

                    case 2:
                        string select = "SELECT * FROM dischi";
                        MySqlCommand cmdSelect = new MySqlCommand(select, conn);
                        using (MySqlDataReader reader = cmdSelect.ExecuteReader()) {
                            Console.WriteLine("\nLista dischi musicali");
                            while (reader.Read()) {
                                Console.WriteLine(
                                    reader["id"] + " | " +
                                    reader["titolo"] + " | " +
                                    reader["genere"] + " | " +
                                    reader["autore"] + " | " +
                                    reader["anno"]
                                );
                                Console.WriteLine("-------------------------------------");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("ID CD: ");
                        int idUpdate = int.Parse(Console.ReadLine());
                        Console.Write("Nuovo titolo: ");
                        string nuovoTitolo = Console.ReadLine();
                        string update = "UPDATE dischi SET titolo=@titolo WHERE id=@id";
                        MySqlCommand cmdUpdate = new MySqlCommand(update, conn);
                        cmdUpdate.Parameters.AddWithValue("@eta", nuovoTitolo);
                        cmdUpdate.Parameters.AddWithValue("@id", idUpdate);
                        cmdUpdate.ExecuteNonQuery();
                        Console.WriteLine("CD aggiornato");
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("ID CD da eliminare: ");
                        int idDelete = int.Parse(Console.ReadLine());
                        string delete = "DELETE FROM dischi WHERE id=@id";
                        MySqlCommand cmdDelete = new MySqlCommand(delete, conn);
                        cmdDelete.Parameters.AddWithValue("@id", idDelete);
                        cmdDelete.ExecuteNonQuery();
                        Console.WriteLine("CD eliminato");
                        Console.WriteLine();
                        break;
                    
                    case 5:
                        Console.WriteLine("Uscita in corso....");
                        return;

                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }
        }
    }
}

