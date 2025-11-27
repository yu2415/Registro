using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroElettronico
{
    public class Account
    {
        int Matricola {  get; set; }
        string Password { get; set; }
        bool Permessi {  get; set; }

        public Account (int matricola, string password, bool permessi)
        {
            Matricola = matricola;
            Password = password;
            Permessi = permessi;
        }

        

    }
}
