using System;
using System.IO;

namespace IntroPOO
{
    /// <summary>
    /// Une banque contient 5 comptes bancaires et permet d'effectuer des opérations sur les comptes
    /// </summary>
    class Banque
    {
        public Banque(string nomFichier)
        {
            using (StreamReader fichierLecture = new StreamReader(nomFichier))
            {
                // Pas de traitement d'erreur, le fichier contiendra toujours 5 lignes valides
                for (int i = 0; i < NbComptes; ++i)
                {
                    string ligne = fichierLecture.ReadLine();

                    _comptes[i] = new CompteBancaire(ligne);
                }
            }
        }

        public void ListerComptes()
        {
            foreach (CompteBancaire item in _comptes)
            {
                item.Afficher();
            }
        }
        public void AfficherSolde(string nomCompte)
        {
            CompteBancaire compte = rechercherCompte(nomCompte);
            if (compte != null)
            {
                // On a trouvé le bon compte
                compte.AfficherSolde();
            }
        }
        public void Deposer(string nomCompte, double montant)
        {
            CompteBancaire compte = rechercherCompte(nomCompte);
            if (compte != null)
            {
                // On a trouvé le bon compte
                compte.Deposer(montant);
            }
        }
        public void Retirer(string nomCompte, double montant)
        {
            CompteBancaire compte = rechercherCompte(nomCompte);
            if (compte != null)
            {
                // On a trouvé le bon compte
                compte.Retirer(montant);
            }
        }
        public void Sauvegarder()
        {
        }

        // Méthode privée car uniquement utilisée par la classe
        // Recherche le compte donné dans le tableau
        // Affiche une erreur si le compte est introvable
        // Retourne le compte trouvé, ou null si le compte est introuvable
        private CompteBancaire rechercherCompte(string nomCompte)
        {
            foreach (CompteBancaire item in _comptes)
            {
                if (item.EstEgaleA(nomCompte))
                {   
                    // On a trouvé le compte
                    return item;
                }
            }

            // Si on arrive ici, on a effectué toute la boucle sans trouver le compte
            Console.WriteLine("Le compte '{0}' n'existe pas", nomCompte);
            return null;
        }


        private const int NbComptes = 5;

        // Un tableau de 5 comptes bancaires.
        // Notez que le tableau est vide et que les comptes ne sont pas initialisés.
        // Dans le constructeur, il sera nécessaire de créer chaque objet contenu dans le tableau:
        //   _comptes[0] = new CompteBancaire(...);
        //   ...
        //   _comptes[4] = new CompteBancaire(...);
        private CompteBancaire[] _comptes = new CompteBancaire[NbComptes]; // 5 comptes à null
    }
}
