namespace Pilastri{
    internal class Program{
        public static void Main(string[] args) {
            var conto = new ContoBancario(1000);
            conto.Deposita(500);
            Console.WriteLine(conto.Saldo);
            conto.Preleva(100);
            Console.WriteLine(conto.Saldo);
            var macchina = new Auto();
            macchina.Marca = "Fiat";
            macchina.NumeroPorte = 5;
            macchina.Avvia();
            macchina.SuonaClacson();
            Animale[] animales = {
                new Cane(),
                new Gatto()
            };
            foreach (var animal in animales) {
                animal.FaiVerso();
            }
        }
    }
}