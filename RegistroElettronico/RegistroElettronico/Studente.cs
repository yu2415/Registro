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
        public int Matricola { get; set; }
        public Studente() { }

        public Studente(string nome, string cognome, string classe, int matricola)
        {
            Nome = nome;
            Cognome = cognome;
            Classe = classe;
            Matricola = matricola;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Classe: {Classe}, N° Matricola {Matricola}";
        }






    }
}
