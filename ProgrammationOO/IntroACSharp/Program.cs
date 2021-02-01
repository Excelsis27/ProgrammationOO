﻿// Notre premier programme en C#
using System;

class Program
{
    static void Main()
    {
        //TestDeBase();
        //TestDeControles();
        //TestDeValeurs();
        //TestTableau();
        TestChaineDeCaracteres();

        Console.Write("Appuyez sur une touche pour continuer");
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
        int nombre1;
        int nombre2;
        int nombre3;

        ObtenirValeurs(out nombre1, out nombre2, out nombre3);
        Console.WriteLine("Valeurs d'origine: " + nombre1 + ", " + nombre2 + ", " + nombre3);

        ModifierValeurs(ref nombre1, ref nombre2, ref nombre3);
        Console.WriteLine("Valeurs modifiées: " + nombre1 + ", " + nombre2 + ", " + nombre3);
    }
    static void ObtenirValeurs(out int valeur1, out int valeur2, out int valeur3)
    {
        valeur1 = 17;
        valeur2 = 42;
        // ------valeur3 n'est initialisée volontairement------
        // Avec out comme type de référence, il faut initialiser toutes les variables
        valeur3 = 49;
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

    static void TestTableau()
    {
        int[] tableauEntiers = { 0, 1, 2, 3, 5, 8, 13 }; // Un tableau de 7 éléments

        tableauEntiers[0] = 1;

        Console.WriteLine("Le tableau contient {0} éléments", tableauEntiers.Length);
        Console.WriteLine("Le premier élément est: " + tableauEntiers[0]);
        Console.WriteLine("Le dernier élément est: " + tableauEntiers[tableauEntiers.Length - 1]);

        // Va faire planter le programme
        //Console.WriteLine("Élément après le dernier: " + tableauEntiers[ tableauEntiers.Length]); // Out of range, ne fonctionne pas
        //tableauEntiers[12] = 21; //pareil ici

        for (int i = 0; i < tableauEntiers.Length; i++)
        {
            Console.Write(tableauEntiers[i] + ", ");
        }
        Console.WriteLine();

        Console.WriteLine("Boucle foreach");
        foreach (int item in tableauEntiers)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();


        // Tableau de chaines de caractrères
        string[] nomsMois = { "Janvier", "Fébrier", "Mars", "Mai" };
        Console.WriteLine("Le 2e mois est: " + nomsMois[1]);
        nomsMois[3] = "Avril";

        foreach (string item in nomsMois)
        {
            Console.WriteLine(item + ", ");
        }
        Console.WriteLine();
    }

    static void TestChaineDeCaracteres()
    {
        string maChaine = "Bonjour";

        // Length est disponible pour les strings
        Console.WriteLine("Longueur de la chaine: " + maChaine.Length + ", le 1er caractère est '" + maChaine[0] + "'" + "et le dernier caractère est '" + maChaine[maChaine.Length - 1] + "'");

        foreach (char item in maChaine)
        {
            Console.WriteLine(item);
        }

        // Impossible de modifier le contenu d'une chaine individuellement
        //maChaine[1] = 'a';

        // On peut remplacer la chaine au complet comme ceci
        maChaine = "Ceci est";
        maChaine += " un tes";
        maChaine += 't'; // += fonctionne avec un seul caractère

        // Divise la chaine en sous-chaines à chaque occurence du caractère donné
        string[] mots = maChaine.Split(' ');
        foreach (string mot in mots)
        {
            Console.WriteLine(mot);
        }

        maChaine = "            Une chaine de caractères avec des espaces avant et après.           ";
        Console.WriteLine("Chaine originale: \"{0}\"", maChaine);
        // Trim enlève les espaces au début et à la fin + TrimStart/TrimEnd
        maChaine.Trim();
        Console.WriteLine("Chaine sans espaces: \"{0}\"", maChaine);
        maChaine = maChaine.Trim();
        Console.WriteLine("Chaine sans espaces (prise 2): \"{0}\"", maChaine);

        string aChercher = "Une";
        if (maChaine.Contains(aChercher))
        {
            Console.WriteLine("La chaine contient " + aChercher);

            if (maChaine.StartsWith(aChercher))
            {
                Console.WriteLine("La chaine débute par " + aChercher);
            }
            else
            {
                Console.WriteLine("La chaine ne débute pas par " + aChercher);
            }

        }
        else
        {
            Console.WriteLine("La chaine ne contient pas " + aChercher);
        }
    }
}