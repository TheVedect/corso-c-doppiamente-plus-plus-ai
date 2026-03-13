using System;
using System.Collections.Generic;

namespace Tombola{
    public class Giocatore{

        public string nome_giocatore;
        public int numero_cartelle;
        public List<Cartella> cartelle  = new List<Cartella>();

        public Giocatore(string nome, int N) {
            nome_giocatore = nome;
            for (int i = 0; i < N; i++) {
                Cartella cartella = new Cartella();
                cartelle.Add(cartella);
            }
        }
    }
}
