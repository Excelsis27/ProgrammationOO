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
            //TestListeDates();
            //TestListePersonnes();
            //TestFile();
            //TestPile();
            //Exercices.TestDeplacement();
            Exercices.TestEtudiants();

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
            Console.WriteLine("Dernier élément: " + listeEntiers[listeEntiers.Count - 1]);
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

                if (date == aujourdhui)
                {
                    Console.WriteLine("C'est la date d'aujourd'hui");
                }
                else if (date < aujourdhui)
                {
                    TimeSpan diff = aujourdhui - date;
                    Console.WriteLine("C'est une date passée de {0} jour", diff.Days);
                }
                else
                {
                    TimeSpan diff = date - aujourdhui;
                    Console.WriteLine("C'est une date future de {0} heures", diff.TotalHours);
                }

                if (DateTime.IsLeapYear(date.Year))
                {
                    Console.WriteLine("{0} est une année bissextile.", date.Year);
                }

                Console.WriteLine("Le mois de {0} compte {1} jours", date.ToString("M"), DateTime.DaysInMonth(date.Year, date.Month));

                Console.Write("Indiquez une date et une heure (A/M/J H:M:S): ");
                date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(" Date courte: " + date.ToShortDateString());
                Console.WriteLine(" Date longue: " + date.ToLongDateString());
                Console.WriteLine(" Heure courte: " + date.ToShortTimeString());
                Console.WriteLine(" Heure longue: " + date.ToLongTimeString());
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

        static void TestListePersonnes()
        {
            List<Personne> listePersonnes = new List<Personne>();

            listePersonnes.Add(new Personne("Andre", "Lapointe", 32));
            listePersonnes.Add(new Personne("Melissa", "Hemond", 42));
            listePersonnes.Add(new Personne("Monique", "Lapointe", 62));

            // faute d'ortographe
            Personne donatien = new Personne("Donatn", "Dallaire", 52);
            // On ajoute une RÉFÉRENCE à l'objet dans la liste
            listePersonnes.Add(donatien);

            foreach (var item in listePersonnes)
            {
                item.Afficher();
            }

            // Modification de la variable donatien
            donatien.Prenom = "Donatien";

            Console.WriteLine("-------------------");

            foreach (var item in listePersonnes)
            {
                item.Afficher();
            }

            // On va retrouver le même objet dans la liste
            if (listePersonnes.Contains(donatien))
            {
                Console.WriteLine("***Donatien est parmis nous");
            }
            else
            {
                Console.WriteLine("Donatien nous a pas encore rejoin");
            }

            Personne donatien2 = new Personne("Donatien", "Dallaire", 52);

            // On ne retrouvera pas un autre objet, même si les valeurs sont identiques
            if (listePersonnes.Contains(donatien2))
            {
                Console.WriteLine("Donatien2 est parmis nous");
            }
            else
            {
                Console.WriteLine("***Donatien2 nous a pas encore rejoin");
            }

            try
            {
                // Le tri ne va pas fonctionner
                // Comment comparer : Par nom? Par prénom? Par âge? ...
                listePersonnes.Sort();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void TestFile()
        {
            // Une file est une structure dans laquelle il n'est possible d'ajouter des éléments qu'à la fin et de les retirer qu'au début
            // Exemple: une file d'attente
            Queue<string> clients = new Queue<string>();

            // Enqueue = Enfiler: ajoute à la fin de la file (comme Add pour une liste)
            clients.Enqueue("Jonathan");
            clients.Enqueue("André");
            clients.Enqueue("Alex");

            AfficherFile(clients);

            Console.WriteLine("Le client en tête de liste est: " + clients.Peek());

            // Dequeue = Défiler, enlève au début de la file
            string clientAServir = clients.Dequeue();
            Console.WriteLine("On sert le client: " + clientAServir);

            AfficherFile(clients);

            Console.WriteLine("Dolorès arrive dans la file");
            clients.Enqueue("Dolorès");
            AfficherFile(clients);

            clientAServir = clients.Dequeue();
            Console.WriteLine("On sert maintenant: " + clientAServir);
            AfficherFile(clients);

            // On utilise une fille lorsqu'on doit conserver l'ordre des éléments tel qu'ils ont été ajoutés

            // Premier arriver, premier servi. (FIFO, first in, first out)
        }

        static void AfficherFile(Queue<string> s)
        {

            Console.WriteLine("------------------");
            Console.WriteLine("Taille de la file: " + s.Count);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
        }

        static void TestPile()
        {
            // Une pile est une structure dans laquelle il n'est possible d'ajouter et de retirer des éléments qu'au début
            // Exemple: une pile d'assiettes

            Stack<CarteAJouer> cartes = new Stack<CarteAJouer>();

            // Push ajoute un élément sur le dessus de la pile
            cartes.Push(new CarteAJouer(2, Suite.Carreau));
            cartes.Push(new CarteAJouer(10, Suite.Trefle));
            cartes.Push(new CarteAJouer(13, Suite.Pique));
            cartes.Push(new CarteAJouer(1, Suite.Coeur));
            cartes.Push(new CarteAJouer(6, Suite.Trefle));

            foreach (var item in cartes)
            {
                Console.WriteLine(item.Description);
            }

            Console.WriteLine("La carte sur le dessus du paquet: " + cartes.Peek().Description);

            // Pop enlève un élément du dessus de la pile
            CarteAJouer uneCarte = cartes.Pop();

            Console.WriteLine("Carte prise sur le dessus du paquet: " + uneCarte.Description);

            uneCarte = cartes.Pop();

            Console.WriteLine("Prochaine carte prise sur le dessus du paquet: " + uneCarte.Description);

            Console.WriteLine("Ajoute une carte sur la pile");
            cartes.Push(new CarteAJouer(7, Suite.Pique));
            Console.WriteLine("La carte sur le dessus du paquet: " + cartes.Peek().Description);

            // Dernier arrivé, premier servi (LIFO: last in, first out)
            // Exemple: Flèche au backgammon
        }

        static void Pause()
        {
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
