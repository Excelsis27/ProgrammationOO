using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    /// <summary>
    /// Tous les types de comptes possibles
    /// </summary>
    enum TypeCompte
    { 
        Cheque,
        Epargne
    }

    /// <summary>
    /// Représentation d'un compte contenu dans la banque
    /// </summary>
    class CompteBancaire
    {
        //private const int Cheque = 0;
        //private const int Epargne = 1; // Les valeurs doivent être différentes

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="ligneFichier">La ligne lue du fichier</param>
        public CompteBancaire(string ligneFichier)
        {
            string[] elements = ligneFichier.Split(';');

            switch (elements[0])
            {
                case "Cheque":
                    _type = TypeCompte.Cheque;
                    break;
                case "Epargne":
                    _type = TypeCompte.Epargne;
                    break;
                    // Pour l'instant, on ne gère pas les erreurs
            }

            _nom = elements[1]; // readonly, doit être initialisé dans le constructeur
            _solde = Convert.ToDouble(elements[2]);

            // Le numéro doît être unique, 2 comptes ne doivent pas avoir le même
            // On incrémente le dernier numéro, et on utilise cette valeur
            _numero = ++_dernierNumero;
        }

        /// <summary>
        /// Accesseur du dernier numéro
        /// </summary>
        /// <returns>Retourne le dernier numéro utilisé</returns>
        public static int DernierNumero()
        {
            // return _numero; Invalide, ne peut pas utiliser d'attribut non static'
            return _dernierNumero;
        }

        /// <summary>
        /// Affiche l'imformation du compte
        /// </summary>
        public void Afficher()
        {
            // Impossible de modifier un attribut readonly
            // _nom = "Nouveau nom";
            Console.WriteLine("Compte {0} ({1}): {2}", _type, _numero, _nom);
        }

        /// <summary>
        /// Indique si le compte porte le nom donné
        /// </summary>
        /// <param name="nom">Le nom à valider</param>
        /// <returns>Vrai si le nom correspond, faux sinon</returns>
        public bool EstEgaleA(string nom)
        {
            return nom == _nom;
        }

        /// <summary>
        /// Affiche le solde du compte
        /// </summary>
        public void AfficherSolde()
        {
            // Format C = Currency (Devise: $)
            Console.WriteLine("Solde du compte '{0}': {1:C}", _nom, _solde);
        }

        /// <summary>
        /// Effectue un dépot dans le compte
        /// </summary>
        /// <param name="montant">Montant à déposer</param>
        public void Deposer(double montant)
        {
            // On ajoute le montant au solder
            _solde += montant;
            Console.WriteLine("Dépot de {0:C} dans le compte {1}, nouveau solder: {2:C}", montant, _nom, _solde);
        }
        /// <summary>
        /// Effectue un retrait dans le compte
        /// Affiche un message d'erreur si le solde est insuffisant. Le solde reste alors inchangé
        /// </summary>
        /// <param name="montant">Montant à retirer</param>
        public void Retirer(double montant)
        {
            if (montant <= _solde)
            {
                // Le solde est suffisant
                _solde -= montant;
                Console.WriteLine("Retrait de {0:C} du compte {1}, nouveau solde: {2:C}", montant, _nom, _solde);
            }
            else
            {
                Console.WriteLine("Retrait impossible, solder insuffisant");
            }
        }

        /// <summary>
        /// Prépare l'information du compte pour la sauvegarde dans un fichier
        /// </summary>
        /// <returns>Ligne décrivant  le compte à écrire dans le fichier</returns>
        public string SauvegardeFichier()
        {
            // Doit être symétrique à la lecture. On effectue l'opération inversion du constructeur

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0};{1};{2}", _type, _nom, _solde);

            return sb.ToString();
        }

        // Pour assigner un numéro unique à chaque compte
        private static int _dernierNumero = 1000;

        // Le type et le nom ne peuvent pas être modifiés après la construction de l'objet
        private readonly TypeCompte _type;
        private readonly string _nom;
        private double _solde;
        // Numéro qui identifie le compte de manière unique
        private readonly int _numero;
    }
}
