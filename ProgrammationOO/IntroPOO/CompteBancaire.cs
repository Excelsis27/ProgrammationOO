using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    class CompteBancaire
    {

        public CompteBancaire(string ligneFichier)
        {
            string[] elements = ligneFichier.Split(';');

            _type = elements[0];
            _nom = elements[1]; // readonly, doit être initialisé dans le constructeur
            _solde = Convert.ToDouble(elements[2]);
        }
        /// <summary>
        /// Affiche l'imformation du compte
        /// </summary>
        public void Afficher()
        {
            // Impossible de modifier un attribut readonly
            // _nom = "Nouveau nom";
            Console.WriteLine("Compte {0}: {1}", _type, _nom);
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

        // Le type et le nom ne peuvent pas être modifiés après la construction de l'objet
        private readonly string _type;
        private readonly string _nom;
        private double _solde;
    }
}
