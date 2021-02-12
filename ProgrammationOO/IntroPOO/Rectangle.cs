using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    class Rectangle
    {
        public Rectangle() // Constructeur par défaut --> sans paramètre
        {
            _largeur = 4;
            _hauteur = 2;
            Console.WriteLine("Constructeur de Rectangle par défaut");
        }

        public Rectangle(int largeur, int hauteur, string nom)
        {
            //_largeur = largeur;
            //_hauteur = hauteur;

            // Pour profiter des validations existantes
            SetLargeur(largeur);
            Hauteur = hauteur;
            Nom = nom;
            Console.WriteLine("Constructeur de Rectangle avec largeur = {0}, hauteur = {1}, nom {2}", largeur, hauteur, nom);
        }

        // Accesseur (getter)
        public int GetLargeur()
        {
            return _largeur;
        }

        // Mutateur (setter)
        public void SetLargeur(int value)
        {
            // La largeur ne peut pas être négative, ni nulle
            if (value > 0 && value < MaxLargeur)
            {
                _largeur = value;
            }
        }

        // Propriété
        public int Hauteur  // Pas de parenthèses
        {
            // Dans le bloc d'une propriété, il est possible de définir deux simili-méthodes

            // Accesseur
            get { return _hauteur; }

            // Mutateur
            set // implicitement (int value) 
            {
                // Dans la partir set d'une propriété, une variable est nommée "value" existe
                // implicitement pour contenir la valeur assignée
                if (value > 0)
                {
                    _hauteur = value;
                }
            }
        }

        public void SetCouleur(int value)
        {
            // Fonctionne car set est private
            Couleur = value;
        }

        /*
        private string _nom = "Rectangle";
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }*/

        // Propriété automatique
        // Une valeur interne est utilise implicitement, sans qu'on ai à définir un attribut _nom
        public string Nom { get; set; } = "Rectangle";

        // Propriété automatique, en lecture seule de l'extérieur de la classe.
        // Modifiable dans la classe
        public int Couleur { get; private set; } = 15;

        // Méthode qui retourne la surface du rectangle
        public int CalculerSurface()
        {
            return _largeur * _hauteur;
        }
        // Propriété pour récupérer la surface du rectangle
        public int Surface
        {
            get { return _largeur * _hauteur; }
            // Propriété en lecture seule, on ne définit pas la méthode set
        }


        public void Dessiner(char symbole)
        {
            for (int ligne = 0; ligne < _hauteur; ++ligne)
            {
                for (int colonne = 0; colonne < _largeur; ++colonne)
                {
                    Console.Write(symbole);
                }
                Console.WriteLine();
            }
        }

        // Il est possible d'avoir plusieurs méthodes avec le même nom, si les paramètres sont différents
        public void Dessiner()
        {
            // Appelle la version qui prend un caractère
            Dessiner('@');
        }


        public void AfficherDetails()
        {
            Console.WriteLine("{0}: Largeur = {1}, Hauteur: {2}, Couleur = {3}, Surface = {4}", Nom, _largeur, _hauteur, Couleur, Surface);

        }

        private const int MaxLargeur = 80;

        private int _largeur = 1;
        private int _hauteur = 1;
    }
}
