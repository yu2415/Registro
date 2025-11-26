namespace RegistroElettronico
{
    internal class RegistroDiClasse
    {
        static void Main(string[] args)
        {

            Studente studente1 = CreaStudente();
            Console.WriteLine(studente1);
            Console.WriteLine("studente creato!");
            Studente studente2 = CreaStudente();
            Console.WriteLine(studente2);
            Console.WriteLine("studente creato!");

            List<Studente> classe1 = new List<Studente> { studente1, studente2 };

            Classe classe = new Classe(4, 'i', classe1);

            AggiornaOrdineComplessivo(classe);

            string result;

            for (int i = 0; i < classe1.Count; i++)
            {
                result = classe1[i].ToString();
                Console.WriteLine(result);
            }

        }

        
        
        public static Studente CreaStudente()
        {
            Studente studente = new Studente();
            Console.WriteLine("Inserire il nome dello studente");
            studente.Nome = Console.ReadLine();
            Console.WriteLine("Inserire il cognome dello studente");
            studente.Cognome = Console.ReadLine();
            Console.WriteLine("Inserire la classe dello studente");
            studente.Classe = Console.ReadLine();

            Random random = new Random();
            studente.Matricola = random.Next();

            return studente;
        }

        

        public static Studente MaggiorePerCognomeNomeStudente(Studente studente1, Studente studente2)
        {
            // inizializziamo tutte le variabili che ci servono ad ordinare i nostri due studenti
            List<Studente> ordinaStudente = [studente1, studente2];
            string aux = "";

            bool equalCognome = (studente1.Cognome == studente2.Cognome);
            bool equalNome = (studente1.Nome == studente2.Nome);



            // troviamo la lunghezza minima per iterare nel for
            //cognome

            int lunghezzaMinimaCognome = 0;
            if (studente1.Cognome.Length > studente2.Cognome.Length)
            {
                lunghezzaMinimaCognome = studente2.Cognome.Length;
            }
            else
            {
                lunghezzaMinimaCognome = studente1.Cognome.Length;
            }
            //nome
            int lunghezzaMinimaNome = 0;
            if (studente1.Nome.Length > studente2.Nome.Length)
            {
                lunghezzaMinimaNome = studente2.Nome.Length;
            }
            else
            {
                lunghezzaMinimaCognome = studente1.Nome.Length;
            }



            //per ordinar e facciamo un for usando le lunghezze trovate precedentemente

            if (!equalCognome)
            {
                for (int i = 0; i < lunghezzaMinimaCognome; i++)
                {
                    char c1 = ordinaStudente[0].Cognome[i]; //char che scorre nella nostra stringa Cognome riuscendo a capire se un carattere è maggiore di un altro
                    char c2 = ordinaStudente[1].Cognome[i];

                    if (c2 > c1)
                    {
                        i = lunghezzaMinimaCognome; // se c1 è minore allora il cognome del primo studente è minore del cognome del secondo, quindi è prima nell'elenco il primo studente

                    }

                    else if (c2 < c1) // se c1 è maggiore di c2 vuol dire che il cognome del secondo studente è minore del cognome del primo, quindi è prima nell'elenco il secondo studente
                    {

                        // scambiamo i cognomi
                        aux = ordinaStudente[0].Cognome;
                        ordinaStudente[0].Cognome = ordinaStudente[1].Cognome;
                        ordinaStudente[1].Cognome = aux;

                        //scambiamo i nomi
                        aux = ordinaStudente[0].Nome;
                        ordinaStudente[0].Nome = ordinaStudente[1].Nome;
                        ordinaStudente[1].Nome = aux;
                    }
                }
            }
            if (!equalNome)
            {
                for (int j = 0; j <= lunghezzaMinimaNome; j++)
                {
                    char n1 = studente1.Nome[j];
                    char n2 = studente2.Nome[j];
                    if (n2 > n1)
                    {
                        j = lunghezzaMinimaNome;
                    }
                    else if (n2 < n1)
                    {
                        aux = ordinaStudente[0].Cognome;
                        ordinaStudente[0].Cognome = ordinaStudente[1].Cognome;
                        ordinaStudente[1].Cognome = aux;

                        aux = ordinaStudente[0].Nome;
                        ordinaStudente[0].Nome = ordinaStudente[1].Nome;
                        ordinaStudente[1].Nome = aux;
                    }
                }
            }

            return ordinaStudente[0];
        }

        

        public static void AggiornaOrdineComplessivo(Classe classe)
        {
            List<Studente> studentiDardinare = classe.StudentiClasse;

            for (int i = 0; i < studentiDardinare.Count; i++)
            {
                for (int j = i; j < studentiDardinare.Count; j++)
                {
                    studentiDardinare [i] = MaggiorePerCognomeNomeStudente(studentiDardinare[i], studentiDardinare[j]);
                }
            }

            classe.StudentiClasse = studentiDardinare;

        }

        public void AggiungiVoto()
        {
            Voto voto= new Voto();
            Console.WriteLine("Inserisci la materia:");
            voto.Materia = Console.ReadLine();
            string risposta;
            Console.WriteLine("Vuoi inserire un commento al voto:(s/n)");
            risposta=Console.ReadLine();
            if (risposta == "s")
            {
                Console.WriteLine("Inserisci il commento:");
                voto.Commento=Console.ReadLine();
            }
            Console.WriteLine("Inserisci la data:");
            voto.Data = DateTime.Parse(Console.ReadLine());
        }

        public void AggiungiStudente()
        {
            Classe classe = new Classe();
            Studente studente = new Studente();
            Console.WriteLine("Inserisci il nome:");
            studente.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome:");
            studente.Cognome = Console.ReadLine();
            Console.WriteLine("Inserisci la classe:");
            studente.Classe = Console.ReadLine();
            Console.WriteLine("Inserisci il numero di registro:");
            studente.Matricola = int.Parse(Console.ReadLine());
            classe.StudentiClasse.Add(studente);
        }

        public void CreaClasse()
        {
            Classe classe = new Classe();
            Console.WriteLine("Inserisci l'anno della classe corrente:");
            classe.Anno = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la sezione della classe corrente:");
            classe.Sezione= char.Parse(Console.ReadLine());


        }


    }
}