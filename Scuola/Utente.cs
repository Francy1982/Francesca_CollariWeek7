using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola
{
    internal class Utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; } 

        int Eta { get; set; }

        public Utente()
        {

        }

        public Utente(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;  
            Eta = eta;  
        }
    }
}
