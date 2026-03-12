namespace Pilastri{
    public class Veicolo{
        private string marca;

        public string Marca {
            get { 
                return marca;
            }
            set { 
                marca = value; 
            }
        }

        public void Avvia() {
            Console.WriteLine("Avvia.");
        }
    }
    
    public class Auto: Veicolo{
        public int NumeroPorte { get; set; }

        public void SuonaClacson() {
            Console.WriteLine("Suona Clacson la macchina " + Marca + " che ha " + NumeroPorte + " porte.");
        }
    }
    
}

