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
        public string Password { get; set; }
        public bool Permessi { get; set; }
        public FileAttributes Note {  get; set; }

        public Studente() { }

        public Studente(int matricola , string nome, string cognome, string classe, string password, bool permessi)
        {
            Nome = nome;
            Cognome = cognome;
            Classe = classe;
            Matricola = matricola;
            Password = password;
            Permessi = permessi;
        }

        public Studente (int matricola, string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
            Matricola = matricola;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Classe: {Classe}, N° Matricola {Matricola}";
        }

        public string Serializza()
        {
            return $"{Matricola} - {Nome} - {Cognome} - {Classe}";
        }

        public static Studente Deserializza(string rigaDelFile)
        {
            var parti = rigaDelFile.Split("-");
            int matricola = int.Parse(parti[0]);
            string nome = parti[1];
            string cognome = parti[2];
            string classe = parti[3];
            return new Studente (matricola, nome, cognome, classe);

        }

        public static int GetMatricola(string rigaDelFile)
        {
            var parti = rigaDelFile.Split("-");
            return int.Parse (parti[0]);
        }

        

        


    }
}
