using System;

namespace Prova_finale
{
    class Program
    {
        //Risposte domande:
        //1) c,d
        //2) b,c
        //3) d


        static void Main(string[] args)
        {
            do
            {


                Console.WriteLine("Premi 1 - Registrazione");
                Console.WriteLine("Premi 0 - Esci");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        GestoreUser.Registrazione();

                        break;

                    case "0":
                        return;
                }
            } while (true);
        }
    }
}