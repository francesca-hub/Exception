using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_finale
{
    class GestoreUser
    {
        public static void Registrazione()
        {
            Console.WriteLine("Inserisci username");
            string username = Console.ReadLine();

            try
            {
                    //controllo se l'user esiste nel Db

                    bool Esiste = DbManagerConnectedmode.GetUsername(username); //se esiste-->scateno l'eccezione personalizzata

                    if (Esiste) 
                    {
                        throw new UsernamePresenteException("Username già usato");
                    }
                    else 
                    {
                        DbManagerConnectedmode.RegisterUser(username);
                    }
                
            }

            catch (UsernamePresenteException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }
        }
    }
}