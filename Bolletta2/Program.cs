using System;

namespace Bolletta2
{
    class Program
    {
        //  Si richiede di sviluppare un menù attraverso cui l’utente può scegliere di:
        // - inserire i propri dati(nome, cognome e kwH consumati);
        // - richiedere il calcolo del costo della bolletta che è costituito da una quota fissa di 40€ più il prodotto tra i kwH e 10.
        // - stampare a video i valori della bolletta, inclusi nome, cognome e costo pagato.
        // Ciascuna delle operazioni descritte sopra dovrà essere implementata attraverso una opportuna routine.

        static void Main(string[] args)
        {
            // creo bolletta 
            Bolletta bolletta = new Bolletta();

            do
            {
                Console.WriteLine("Scegli \n 1 per  inserire i propri dati \n 2 per calcoare la bolletta \n 3 per stampare la bolletta \n 4 per uscire");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        // creo la bolletta passangoli quella creata da riempire
                        // passo il RIFERIMENTO(ref) cos' le modifche sono valide SEMPRE
                        InserisciDati(ref bolletta);
                        break;
                    case '2':
                        bolletta.CalcoloCostoBolletta();
                        break;
                    case '3':
                        bolletta.StampaDati();
                        break;
                    case '4':
                        return;
                }
            } while (true);
        }

        // metodo per chiedere dati all'utente per creare la bolletta
        private static void InserisciDati(ref Bolletta bolletta)
        {
            // creo un utente da rimpeire con i dati che richiedo 
            // l'utente mi serve per crare la bolletta
            Utente u = new Utente();
            do
            {
                Console.WriteLine("\nInserisci il tuo nome:");
                u.Nome = Console.ReadLine();

                Console.WriteLine("\nInserisci il tuo cognome:");
                u.Cognome = Console.ReadLine();

            } while (u.Nome == "" || u.Cognome == "");

            // creo una variabile che contiente il CONSUMO da chiedere all'utente 
            int consumo;
            //creo un ciclo perprovare a parsale in modo da controllare 
            do
            {
                Console.WriteLine("Inserisci i kwh consumati ");
            } while (!int.TryParse(Console.ReadLine(), out consumo));// provo a parsare il consumo e come output passo consumo che è il valore che voglio ottenere

            // assegno l'utente alla bolletta
            bolletta.Utente = u;

            // assegno il consumo alla bolletta
            bolletta.Consumo = consumo;

            // non è necessario ritornare qualcosa perchè 
            // il metodo è creato per modificare il riferiemtno della bolletta che ci è stata passata

        }
    }
}
