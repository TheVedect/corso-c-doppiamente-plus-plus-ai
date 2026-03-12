namespace Pilastri{
    public class ContoBancario{
        private decimal saldo;
        public decimal Saldo {
            get {
               return saldo; 
            }
            private set {
                saldo = value;
            }
        }

        public ContoBancario(decimal saldoIniziale) {
            Saldo = saldoIniziale;
        }

        public void Deposita(decimal importo) {
            saldo += importo;
        }
        
        public void Preleva(decimal importo) {
            if (importo > 0 && importo <= saldo) {
                saldo -= importo;
            }
        }
    }
}
