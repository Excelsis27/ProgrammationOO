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
            TestRectangle();



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

            Console.WriteLine("{0}: Largeur = {1}, Hauteur: {2}, Couleur = {3}, Surface = {4}", r1.Nom, r1.GetLargeur(), r1.Hauteur, r1.Couleur, r1.Surface);
            // Façon prodécurale
            //DessinerRectangle(r1);
            r1.Dessiner('#');

            Console.WriteLine();
            Rectangle r2 = new Rectangle();
            r2.SetLargeur(17);
            r2.Hauteur = 3;
            Console.WriteLine("{0}: Largeur = {1}, Hauteur: {2}, Couleur = {3}, Surface = {4}", r2.Nom, r2.GetLargeur(), r2.Hauteur, r2.Couleur, r2.Surface);
            //DessinerRectangle(r2);
            r2.Dessiner();
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

        static void Pause()
        {
            Console.Write("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
