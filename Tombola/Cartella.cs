namespace Tombola;

public class Cartella{
    private static int I = 3;
    private static int J = 9;
    public int[,] cartella = new int[I,J];
    public List<int> numeri_usciti = new List<int>();

    public Cartella(int numero_della_tabella) {
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 5; j++) {
                cartella[i,j] = (j + 1) + i * 10 + (numero_della_tabella % 3) * 30 + (numero_della_tabella / 3) * 5;
            }
        }
    }

    public Cartella() {
        Random rnd = new Random();
        int x = 0;
        int y = 0;
        int z = 0;
        int a = 0;
        int b = 0;
        for (int j = 0; j < J; j++) {
            while(true) {
                a = rnd.Next(0,3);
                if (a == 0) {
                    if (x < 5) {
                        x++;
                        break;
                    }
                }
                if (a == 1) {
                    if (y < 5) {
                        y++;
                        break;
                    }
                }
                if (a == 2) {
                    if (z < 5) {
                        z++;
                        break;
                    }
                }
            }
            while (true) {
                int n;
                if (j == 0) {
                    n = rnd.Next(1, 10);
                }else if (j == 8) {
                    n = j * 10 + rnd.Next(0, 11);
                }else {
                    n = j * 10 + rnd.Next(0, 10);
                }
                if (!numeri_usciti.Contains(n)) {
                    numeri_usciti.Add(n);
                    cartella[a,j] = n;
                    break;
                }
            }
        }
        //ULTIMI 5 NUMERI
        for (int j = 0; j<6; j++) {
            while(true) {
                while (true) {
                    a = rnd.Next(0,3);
                    b = rnd.Next(0,9);
                    if (cartella[a, b] == 0) {
                        break;
                    }
                }
                if (a == 0) {
                    if (x < 5) {
                        x++;
                        break;
                    }
                }
                if (a == 1) {
                    if (y < 5) {
                        y++;
                        break;
                    }
                }
                if (a == 2) {
                    if (z < 5) {
                        z++;
                        break;
                    }
                }
            }
            while (true) {
                int n = 0;
                if (b == 0) {
                    n = rnd.Next(1, 10);
                }else if (b == 8) {
                    n = b * 10 + rnd.Next(0, 11);
                }else {
                    n = b * 10 + rnd.Next(0, 10);
                }
                if (!numeri_usciti.Contains(n)) {
                    numeri_usciti.Add(n);
                    cartella[a,b] = n;
                    break;
                }
            }
        }
    }

    public void AggiornaCartella(int numero_estratto) {
        for (int i = 0; i < I; i++) {
            for (int j = 0; j < J; j++) {
                if (cartella[i, j] == numero_estratto) {
                    cartella[i, j] = -1;
                    break;
                }
            }
        }
    }

    public void VisualizzaCartella() {
        for (int i = 0; i < I; i++) {
            for (int j = 0; j < J; j++) {
                Console.Write(cartella[i,j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void VisualizzaCartella(int ii, int jj) {
        for (int i = 0; i < ii; i++) {
            for (int j = 0; j < jj; j++) {
                Console.Write(cartella[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}