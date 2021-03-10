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
            //TestListeEntiers();
            //TestListeStrings();
            TestListeDates();

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

            Console.WriteLine("Premier élément: " + listeEntiers[0]);
            Console.WriteLine("Dernier élément: " + listeEntiers[listeEntiers.Count- 1]);
            listeEntiers[2] = 100;


            // Trier la liste en ordre croissant
            listeEntiers.Sort();

            Console.WriteLine("En ordre croissant: " + listeEntiers);
            foreach (var item in listeEntiers)
            {
                Console.WriteLine(item);
            }
        }

        static void TestListeStrings()
        {
            List<string> listeStrings = new List<string>() { "Un", "Trois", "Quatre", "Trois", "Quatre" };
            AfficherListeStrings(listeStrings);

            Console.WriteLine("Insertion de \"Deux\" à la position 1 (2e)");
            listeStrings.Insert(1, "Deux");
            AfficherListeStrings(listeStrings);

            // Insert(0,...) insère au début de la liste
            Console.WriteLine("Insertion de \"Zéro\" à la position 0 (1e)");
            listeStrings.Insert(0, "Zéro");
            AfficherListeStrings(listeStrings);

            int index = listeStrings.IndexOf("Trois");
            Console.WriteLine("Première position de \"Trois\": " + index);
            Console.WriteLine("Prochaine position de \"Trois\": " + listeStrings.IndexOf("Trois", index + 1));
            Console.WriteLine("Dernière position de \"Trois\": " + listeStrings.LastIndexOf("Trois"));
            // -1 si la valeur n'est pas trouvé
            Console.WriteLine("Position de \"Cinq\" : " + listeStrings.IndexOf("Cinq"));

            if (listeStrings.Contains("Trois"))
            {
                Console.WriteLine("La liste contient \"Trois\".");
            }

            Console.WriteLine("Enlever la première occurence de \"Quatre\" ");
            listeStrings.Remove("Quatre");
            AfficherListeStrings(listeStrings);
            Console.WriteLine("Élément à la position 4: " + listeStrings[4]);
            Console.WriteLine("Enlève l'élément à la position 4");
            listeStrings.RemoveAt(4);
            AfficherListeStrings(listeStrings);

            // Trier la liste en ordre décroissant
            // Tri en ordre croissant
            listeStrings.Sort();
            // ... puis on inverse la liste
            listeStrings.Reverse();

            Console.WriteLine("En ordre décroissant: " + listeStrings);
            AfficherListeStrings(listeStrings);

            Console.WriteLine("On vid la liste");
            listeStrings.Clear();
            AfficherListeStrings(listeStrings);
        }


        static void AfficherListeStrings(List<string> listeString)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Taille de la liste: " + listeString.Count);
            foreach (var item in listeString)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
        }


        static void TestListeDates()
        {
            List<DateTime> listeDate = new List<DateTime>()
            {
                // Année, Mois, Jour
                new DateTime(2020, 7, 21),
                new DateTime(1988, 4, 26),
                new DateTime(2005, 3, 5),
                // Année, Mois, Jour, Heure, Minute, Seconde
                new DateTime(1984, 4, 1, 10, 32, 55)
            };

            // La propriété statique Now retourne un objet DateTime initialisé à l'heure actualle de l'ordinateur
            DateTime maintenant = DateTime.Now;
            Console.WriteLine(maintenant);
            Console.WriteLine("---------");

            listeDate.Add(maintenant);
            DateTime aujourdhui = DateTime.Today;
            Console.WriteLine(aujourdhui);
            Console.WriteLine("---------");

            listeDate.Add(aujourdhui);

            try
            {
                Console.Write("Indiquez une date (A/M/J): ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(" Date courte: " + date.ToShortDateString());
                Console.WriteLine(" Date longue: " + date.ToLongDateString());
                listeDate.Add(date);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            listeDate.Sort();

            foreach (var item in listeDate)
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
