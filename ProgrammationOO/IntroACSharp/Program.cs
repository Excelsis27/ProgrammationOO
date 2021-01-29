// Notre premier programme en C#
using System;

class Program
{
    static void Main()
    {
        //TestDeBase();
        //TestDeControles();
        TestDeValeurs();

        Console.WriteLine("Appuyez sur une touche pour continuer");
        Console.ReadKey();
    }


    static void TestDeBase()
    {
        // Writeline inclut le changement de ligne
        Console.WriteLine("Bonjour tout le monde");

        Console.WriteLine("Appuyez sur une touche pour continuer");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Bienvenue au cours de \nProgrammation Orientée Objet");

        Console.WriteLine("Appuyez sur une touche pour continuer");
        Console.ReadKey();
        Console.Clear();

        // Types de base
        int entier = 12;
        double nombreReel = 34.56;
        char caractere = 'C';
        bool booleen = true;

        // Types complexe
        string chaineDeCaracteres = "Bonjour la police";

        // Constantes sont en PascalCase
        const double Pi = 3.1415;

        Console.WriteLine("Entier: " + entier + ", réel: " + nombreReel + ", caractère: " + caractere + ", booléen: " + booleen + ", chaine: " + chaineDeCaracteres);

        Console.WriteLine("Entier: {0}, réel: {1}, chaine: {2}, l'entier est toujours: {0}", entier, nombreReel, chaineDeCaracteres);

        Console.Write("Entrez du texte: ");
        string lecture = Console.ReadLine();
        Console.WriteLine("Texte: \"" + lecture + "\"");
    }

    static int ObtenirEntier(int min, int max)
    {
        Console.WriteLine("Entrez un entier entre " + min + " et " + max + " : ");
        string ligne = Console.ReadLine();
        // On ne valide pas les erreurs, le programme va planter si l'utilisateur ne donne pas un entier
        return Convert.ToInt32(ligne);
    }

    static void TestDeControles()
    {
        const int Min = 1;
        const int Max = 10;

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Tentative #" + i + 1);

            while (true)
            {
                int entier = ObtenirEntier(Min, Max);

                if (entier >= Min && entier <= Max)
                {
                    switch (entier)
                    {
                        case 1:
                            Console.WriteLine("Un");
                            break;
                        case 2:
                            Console.WriteLine("Deux");
                            break;
                        case 3:
                            Console.WriteLine("Trois");
                            break;
                        default:
                            Console.WriteLine("Autre valeur");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Valeur incorrecte, essayer de nouveau");
                }
            }
        }

        Console.Write("Entrez un chiffre textuellement: ");
        string s = Console.ReadLine();

        // Le switch accepte une variable de type string
        switch (s)
        {
            // Un case doit absolument avoir un break si une instruction est exécutée
            case "un":
            case "Un":
                Console.WriteLine("1");
                break;
            case "deux":
                Console.WriteLine("2");
                break;
            case "trois":
                Console.WriteLine("3");
                break;
            default:
                Console.WriteLine("Chiffre inconnu");
                break;
        }
    }

    static void TestDeValeurs()
    {
        int nombre1 = 10;
        int nombre2 = 20;
        int nombre3 = 30;

        //ObtenirValeurs(ref nombre1, ref nombre2, ref nombre3);
        Console.WriteLine("Valeurs d'origine: " + nombre1 + ", " + nombre2 + ", " + nombre3);

        ModifierValeurs(ref nombre1, ref nombre2, ref nombre3);
        Console.WriteLine("Valeurs modifiées: " + nombre1 + ", " + nombre2 + ", " + nombre3);
    }
    static void ObtenirValeurs(ref int valeur1, ref int valeur2, ref int valeur3)
    {
        valeur1 = 17;
        valeur2 = 42;
        // valeur3 n'est initialisée volontairement
    }

    static void ModifierValeurs(ref int valeur1, ref int valeur2, ref int valeur3)
    {
        // On pourrait utiliser n'importe quelle opération + - * / %
        // Ou une variante d'assignation: += -= *= /= %=
        // Ou incrémentation ou décrémentation: ++ --
        valeur1 = valeur2 * 5;
        valeur2 += 100;
        valeur3 = (valeur2 + 3) % 7;
    }

}