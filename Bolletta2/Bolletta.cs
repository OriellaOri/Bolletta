using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolletta2
{
    public class Bolletta
    {
        public decimal Quota { get; } = 40;
        public int Consumo { get; set; }
        public Utente Utente { get; set; }
        public decimal Costo { get; set; }

        public Bolletta() { }

        // bolletta è fatta da utente e consumo
        // costruttore 
        public Bolletta(int consumo, Utente utente)
        {
            Consumo = consumo;
            Utente = utente;
        }

        // calcolo il costo della bolletta 
        public void CalcoloCostoBolletta()
        {
            Costo = (Consumo * 10) + Quota;
            Console.WriteLine("\nCalcolo Eseguito");
        }

        public void StampaDati()
        {
            Console.WriteLine($"\nBolletta di {Utente.Nome} {Utente.Cognome} : consumo {Consumo} con una spesa spendi: {Costo} euro");
        }
    }
}
