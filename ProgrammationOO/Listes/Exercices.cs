using System;
using System.Collections.Generic;

namespace Listes
{
    class Exercices
    {
        /// <summary>
        /// Déplace un caractère dans la console selon les touches appuyées par l'utilisateur
        /// </summary>
        public static void TestDeplacement()
        {
            Grille grille = new Grille();
            Stack<Deplacement> deplacements = new Stack<Deplacement>();

            // Tant que l'utilisteur indique un déplacement
            while (Deplacement.Lire(out int deltaX, out int deltaY, out bool annuler))
            {
                // Si CTRL + Z a été appuyé, on annule le dernier déplacement
                if (annuler)
                {
                    // Pop lance une exception si la pile est vide
                    if (deplacements.Count > 0)
                    {
                        Deplacement d = deplacements.Pop();
                        d.Annuler();
                    }
                }
                else // Une flèche
                {
                    // Crée un objet déplacement avec l'info lue, et s'il est valide, on l'effectue
                    Deplacement d = new Deplacement(grille, deltaX, deltaY);
                    if (d.EstValide())
                    {
                        d.Effectuer();
                        // Conserve le déplacement
                        deplacements.Push(d);
                    }
                    // S'il n'est pas valide, on ne fait rien
                }
            }
        }


        /// <summary>
        /// Ajoute des étudiants à une liste, puis les affiche
        /// </summary>
        public static void TestEtudiants()
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            try
            {
                while (true)
                {
                    // Crée un nouvel étudiant
                    Etudiant e = new Etudiant();

                    // Si un étudiant avec le même matricule n'existe pas déjà, on l'ajoute à la liste
                    // Sinon, on affiche un message d'erreur

                    AjouterEtudiant(etudiants, e);
                }
            }
            catch (Exception)
            {
                // On termine la boucle lorsqu'un étudiant n'est pas construit correctement
            }

            // Affiche la liste des étudiants

            AfficherEtudiants(etudiants);

            // S'il y a au moins un étudiant, affiche l'étudiant avec la plus faible note
            Etudiant etudiantNoteMin = null;

            etudiantNoteMin = TrouverNoteMin(etudiants);

            if (etudiantNoteMin != null)
            {
                Console.WriteLine("Étudiant avec la plus faible note: " + etudiantNoteMin.Matricule);
            }
        }

        private static void AjouterEtudiant(List<Etudiant> etudiants, Etudiant e)
        {
            foreach (var item in etudiants)
            {
                if (item.Matricule == e.Matricule)
                {
                    Console.WriteLine("Cet étudiant est déjà dans la liste");
                    return;
                }
            }

            // On n'a pas trouvé le matricule, on peut insérer l'étudiant
            etudiants.Add(e);
        }

        private static void AfficherEtudiants(List<Etudiant> etudiants)
        {
            Console.WriteLine("\nÉtudiants {0}: ", etudiants.Count);
            foreach (var item in etudiants)
            {
                item.Afficher();
            }
            Console.WriteLine();
        }

        private static Etudiant TrouverNoteMin(List<Etudiant> etudiants)
        {
            if (etudiants.Count > 0)
            {
                Etudiant resultat = etudiants[0];

                foreach (var item in etudiants)
                {
                    if (item.Note < resultat.Note)
                    {
                        resultat = item;
                    }
                }

                return resultat;
            }

            return null;
        }
    }
}
