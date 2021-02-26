using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestException();

            Validateur v = new Validateur();
            v.Executer();

            Console.WriteLine("Appuyez sur une touche pour continuer");
            Console.ReadKey(true);
        }


        static void TestException()
        {
            int[] tableau = { 1, 2, 25, 47, 125, 190 };

            bool erreur = true;

            while (erreur) // while(true)
            {
                Console.Write("Entrez un index du tableau: ");
                try
                {
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Index donné: {0}", index);
                    Console.WriteLine("Index {0} du tableau: {1}", index, tableau[index]);
                    Console.WriteLine("Division de la valeur par l'index: " + tableau[index] / index);

                    // Si on se rend ici, tout s'est déroulé sans problème
                    erreur = false; // break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Ceci n'est pas un entier");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Il est impossible diviser par zéro");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une exception de type {0} s'est produite: {1}", ex.GetType(), ex.Message);
                }
            }

            // Pas dans un bloc try, une exception ne sera pas attrappée et va faire planter le programme
            Console.WriteLine("L'éxécution continue après le bloc try/catch");
            Console.Write("Entrez en entier: ");
            Convert.ToInt32(Console.ReadLine());

            try
            {
                DemanderValeur();
                Console.WriteLine("Valeur demandée");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception de base: " + e.Message);
            }
        }

        static void DemanderValeur()
        {
            try
            {
                Console.Write("Entrez une valeur entre 1 et 10: ");
                int valeur = Convert.ToInt32(Console.ReadLine());
                ValiderValeur(valeur);

                Console.WriteLine("La valeur {0} est valide", valeur);
            }
            catch (MonException e)
            //catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            // Un seul type d'exception attrapé, les autres vont continuer
        
        }

        /// <summary>
        /// Valide que la valeur donnée est entre 1 et 10
        /// </summary>
        /// <param name="valeur">La valeur à valider</param>
        /// <exception cref="MonException">Si la valeur n'est pas valide</exception>
        static void ValiderValeur(int valeur)
        {
            if (valeur < 1 || valeur > 10)
            {
                throw new MonException("Valeur invalide, doit être entre 1 et 10");
            }

            Console.WriteLine("Validation terminée");
        }
    }

    // Doit hériter d'Exception
    class MonException : Exception 
    {
        // Constructeur prend un message, qu'il donne au constructeur d'Exception
        // Sera accessible par la propriété Message de l'objet

        public MonException(string message) :
            base(message)
        { 
        
        }
    }
}
