using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroElettronico
{
    public class Voto
    {
        public DateTime Data { get; set; }
        public string Materia {  get; set; }
        public string Commento { get; set; }

        public Voto(string materia,string commento,DateTime data)
        {
            Materia = materia;
            Commento = commento;
            Data = data;
        }

        public Voto(string materia, DateTime data)
        {
            Materia = materia;
            Data = data;
        }

        public override string ToString()
        {
            return $"{Materia} - {Data.ToString("dd/MM/yyyy")} - {Commento}";
        }

        public Voto() { }

        

    }
}
