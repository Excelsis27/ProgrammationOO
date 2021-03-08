using System;
using System.Collections.Generic; // Pour la classe List
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listes
{
    class Program
    {
        static void Main(string[] args)
        {
            TestListeEntiers();


            Pause();
        }

        static void TestListeEntiers()
        {
            // Le type List est un type générique
            // Il faut spécifier le type contenu dans la liste avec la syntaxe: List<TYPE>
            List<int> listeEntiers = new List<int>();

            Random generateurAleatoire = new Random();

            for (int i = 0; i < 10; i++)
            {
                // Add ajoute à la fin de la liste
                listeEntiers.Add(generateurAleatoire.Next(100));
            }

            // Count indique le nombre d'éléments dans la liste
            Console.WriteLine("Taille de la liste: " + listeEntiers.Count);

            foreach (var item in listeEntiers)
            {
                Console.WriteLine(item);
            }
        }

        static void Pause()
        {
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
