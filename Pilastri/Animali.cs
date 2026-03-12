namespace Pilastri{
    public class Animale{
        public virtual void FaiVerso() {
            Console.WriteLine("Fai verso.");
        }
    }
    
    public class Cane: Animale{
        public override void FaiVerso() {
            Console.WriteLine("Fai verso del Cane.");
        }
    }
    
    public class Gatto: Animale{
        public override void FaiVerso() {
            Console.WriteLine("Fai verso del Gatto.");
        }
    }
}

