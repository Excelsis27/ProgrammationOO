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
            r1.SetHauteur(5);


            DessinerRectangle(r1);

            Rectangle r2 = new Rectangle();
            r2.SetLargeur(17);
            r2.SetHauteur(3);

            DessinerRectangle(r2);
        }

        static void DessinerRectangle(Rectangle rectangle)
        {
            for (int ligne = 0; ligne < rectangle.GetHauteur(); ++ligne)
            {
                for (int colonne = 0; colonne < rectangle.GetLargeur(); ++colonne)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }

        static void Pause()
        {
            Console.Write("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
