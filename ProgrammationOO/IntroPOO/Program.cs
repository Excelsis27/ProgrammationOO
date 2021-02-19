using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestRectangle();
            //TestHorloge();

            SimulateurBanque simulateur = new SimulateurBanque();
            simulateur.Simuler();

            Pause();
        }

        static void TestRectangle()
        {
            Rectangle r1 = new Rectangle();
            r1.SetLargeur(10);
            // Une propriété s'utilise comme un attribut
            r1.Hauteur = 5; // va appeler Hauteur.set(5)
            r1.Hauteur = -3;
            r1.Nom = "Rectangle 1";

            r1.AfficherDetails();
            //DessinerRectangle(r1);
            r1.Dessiner('+');

            Rectangle r2 = new Rectangle();
            r2.SetLargeur(17);
            r2.Hauteur = 3;
            r2.AfficherDetails(); //DessinerRectangle(r2);
            r2.Dessiner();

            // Un autre objet de type Rectangle

            Rectangle r3 = new Rectangle();
            r3.AfficherDetails();
            r3.Dessiner('#');

            Rectangle r4 = new Rectangle(17, 14, "Rectangle 4");
            r4.AfficherDetails();
            r4.Dessiner();


            // r4 sera modifié par la méthode
            ModifierRectangle(r4);
            Console.WriteLine("Après l'appel de ModifierRectangle");
            r4.AfficherDetails();
            r4.Dessiner();
        }

        static void ModifierRectangle(Rectangle r)
        {
            // Un objet (variable de type d'une classe) sera toujours considérée comme une référence, même si 'ref' n'est pas spécifié
            r.SetLargeur(3);
            r.Hauteur = 4;

            // Un objet n'est crée que lorsque l'instruction 'new' est appelée. autreRectangle est référence sur r (lui même une référence sur r4)
            // car un nouvel objet n'a pas été créé avec 'new'
            Rectangle autreRectangle = r;
            autreRectangle.SetLargeur(22);
            autreRectangle.Hauteur = 18;
        }

        static void TestHorloge()
        {
            Horloge h0 = new Horloge();
            h0.Afficher(); // 00:00:00

            Horloge h1 = new Horloge(12); // 12:00:00
            h1.Afficher();

            Horloge h2 = new Horloge(12, 34);
            h2.Afficher(); // 12:34:00

            Horloge h3 = new Horloge(12, 34, 56);
            h3.Afficher(); // 12:34:56


            Console.WriteLine("Heures de h3: " + h3.Heures); // 12
            Console.WriteLine("Minutes de h3: " + h3.Minutes); // 34
            Console.WriteLine("Secondes de h3: " + h3.Secondes); // 56

            // Ne doit pas compiler
            /*h3.Heures = 1;
            h3.Minutes = 2;
            h3.Secondes = 3;*/
            // ---------

            // L'horloge valide les heures (entre 0 et 23), minutes et les secondes (entre 0 et 59)
            // Les valeurs invalides sont ignorées silencieusement
            Horloge h4 = new Horloge(3, -5, 67);
            h4.Afficher(); // 03:00:00

            Horloge h5 = new Horloge(12, 34, 0);
            h5.Afficher(); // 12:34:00

            if (h2.EstEgaleA(h5))
            {
                Console.WriteLine("h2 est égale à h5"); // Résultat attendu
            }
            else
            {
                Console.WriteLine("h2 n'est pas égale à h5");
            }

            if (h2.EstEgaleA(h3))
            {
                Console.WriteLine("h2 est égale à h3");
            }
            else
            {
                Console.WriteLine("h2 n'est pas égale à h3"); // Résultat attendu
            }

            // !!! Contrainte
            // La classe horloge ne doit contenir qu'un seul attribut: int _secondesTotales;
            // Contient la valeur de l'horloge sous la forme d'un nombre total de secondes
            // 60 secondes dans une minutes, 3600 secondes dans une heure

        }

        /*
        static void DessinerRectangle(Rectangle rectangle)
        {
            for (int ligne = 0; ligne < rectangle.Hauteur; ++ligne)
            {
                for (int colonne = 0; colonne < rectangle.GetLargeur(); ++colonne)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }*/



        public static void Pause()
        {
            Console.Write("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
