using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;//#salamecasareccio
using System.Threading.Tasks;

namespace RegistroElettronico
{
    public class Classe
    {
        public int Anno {get; set;}
        public char Sezione {get; set;}
        public List<Studente> StudentiClasse { get; set; }

        public Classe(int anno, char sezione, List<Studente> studentiClasse)
        {
            Anno = anno;
            Sezione = sezione;
            StudentiClasse = studentiClasse;
        }

        public Classe() 
        {
             
        }

    }
}
