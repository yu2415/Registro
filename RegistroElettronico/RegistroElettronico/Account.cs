using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroElettronico
{
    public class Account
    {
        public int Matricola {  get; set; }
        public string Password { get; set; }
        public bool Permessi {  get; set; }


        public Account() { }
        public Account (int matricola, string password, bool permessi)
        {
            Matricola = matricola;
            Password = password;
            Permessi = permessi;
        }




    }
}
