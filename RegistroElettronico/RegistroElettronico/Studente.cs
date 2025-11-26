using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroElettronico
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Classe { get; set; }  
        public string NumeroRegistro { get; set; }
        public Studente() { }

        public Studente(string nome, string cognome, string classe, string numeroRegistro)
        {
            Nome = nome;
            Cognome = cognome;
            Classe = classe;
            NumeroRegistro = numeroRegistro;
        }






    }
}
