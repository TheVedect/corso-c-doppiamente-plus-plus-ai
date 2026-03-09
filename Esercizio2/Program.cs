#define ESERCIZIO6
using System;

namespace Esercizio2 {
    internal class Program{
        public static void Main(string[] args) {
            /*ESERCIZIO 1*/
            #if ESERCIZIO1
            int num_1 = 0;
            int num_2 = 0;
            int num_3 = 0;
            Console.WriteLine("Seleziona il primo numero: ");
            num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleziona il secondo numero: ");
            num_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleziona il terzo numero: ");
            num_3 = int.Parse(Console.ReadLine());
            if (num_1 > num_2 && num_1 > num_3) {
                Console.WriteLine("Il primo numero è maggiore degli altri due.");
            }else if (num_2 > num_1 && num_2 > num_3) {
                Console.WriteLine("Il secondo numero è maggiore degli altri due.");
            }else if (num_3 > num_1 && num_3 > num_2) {
                Console.WriteLine("Il terzo numero è maggiore degli altri due.");
            }
            #endif
            
            /*ESERCIZIO 2*/
            #if ESERCIZIO2
            int eta = 0;
            int maggiore_eta = 18;
            Console.WriteLine("Inserisci la tua eta: ");
            eta = int.Parse(Console.ReadLine());
            if (eta >= maggiore_eta) {
                Console.WriteLine("Tu sei maggiorenne!");
            }else {
                Console.WriteLine("Tu sei minorenne!");
            }
            #endif
            
            /*ESERCIZIO 3*/
            #if ESERCIZIO3
            int lato_1 = 0;
            int lato_2 = 0;
            int lato_3 = 0;
            Console.WriteLine("Inserisci il primo lato: ");
            lato_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo lato: ");
            lato_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il terzo lato: ");
            lato_3 = int.Parse(Console.ReadLine());
            if (lato_1 != lato_2 && lato_1 != lato_3 && lato_2 != lato_3) {
                Console.WriteLine("Il triangolo è scaleno.");
            }else if (lato_1 == lato_2 && lato_1 == lato_3) {
                Console.WriteLine("Il triangolo è equilatero.");
            }else {
                Console.WriteLine("Il triangolo è isoscele.");   
            }
            #endif
            
            /*ESERCIZIO 4*/
            #if ESERCIZIO4
            int anno_nascita = 0;
            int anno_luna = 1969;
            Console.WriteLine("Inserisci la data della tua nascita: ");
            anno_nascita = int.Parse(Console.ReadLine());
            int differenza = anno_nascita - anno_luna;
            if (differenza > 0) {
                Console.WriteLine("Sei nato " + differenza + " anni dopo l'atterraggio sulla Luna");
            }else if(differenza < 0) {
                Console.WriteLine("Sei nato " + (-differenza) + " anni prima dell'atterraggio sulla Luna");
            }else {
                Console.WriteLine("Sei nato lo stesso anno dell'atterraggio sulla Luna");   
            }
            #endif
            
            #if ESERCIZIO5
            int numero_settimana = 0;
            Console.WriteLine("Inserisci un numero per ottenere il giorno corrispondente della settimana: ");
            numero_settimana = int.Parse(Console.ReadLine());
            switch (numero_settimana) {
                case 1:
                    Console.WriteLine("Il numero " + numero_settimana + " corrisponde ad un Lunedì." );
                    break;
                case 2:
                    Console.WriteLine("Il numero " + numero_settimana + " corrisponde ad un Martedì." );
                    break;
                case 3:
                    Console.WriteLine("Il numero " + numero_settimana + " corrisponde ad un Mercoledì." );
                    break;
                case 4:
                    Console.WriteLine("Il numero " + numero_settimana + " corrisponde ad un Giovedì." );
                    break;
                case 5:
                    Console.WriteLine("Il numero " + numero_settimana + " corrisponde ad un Venerdì." );
                    break;
                case 6:
                    Console.WriteLine("Il numero " + numero_settimana + " corrisponde ad un Sabato." );
                    break;
                case 7:
                    Console.WriteLine("Il numero " + numero_settimana + " corrisponde ad una Domenica." );
                    break;
                default:
                    Console.WriteLine("Il numero " + numero_settimana + " non corrisponde ad alcun giorno." );
                    break;
            }
            #endif
            
            #if ESERCIZIO6
            int operazione = 0;
            int operando_1 = 0;
            int operando_2 = 0;
            float risultato = 0;
            Console.WriteLine("Seleziona il primo operando: ");
            operando_1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Seleziona il secondo operando: ");
            operando_2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Seleziona l'operazione da fare:\n1-Addizione;\n2-Sottrazione;\n3-Moltiplicazione;\n4-Divisione ");
            operazione = int.Parse(Console.ReadLine());
            switch (operazione) {
                case 1:
                    risultato = operando_1 + operando_2;
                    Console.WriteLine("Operazione dell'addizione: " + risultato);
                    break;
                case 2:
                    risultato = operando_1 - operando_2;
                    Console.WriteLine("Operazione della sottrazione: " + risultato);
                    break;
                case 3:
                    risultato = operando_1 * operando_2;
                    Console.WriteLine("Operazione della moltiplicazione: " + risultato);
                    break;
                case 4:
                    risultato = (float)operando_1 / (float)operando_2;
                    Console.WriteLine("Operazione della divisione: " + risultato);
                    break;
                default:
                    Console.WriteLine("ATTENZIONE! Operazione non valida!");
                    break;
            }
            #endif
        }
    }
};

