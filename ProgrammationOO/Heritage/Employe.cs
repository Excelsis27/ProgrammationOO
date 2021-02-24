using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Employe : Personne
    {
        public Employe()
        {
            Console.WriteLine("Constructeur par défaut d'Employe");
        }
        public Employe(string prenom, string nom, int age, int numEmploye) :
            base(prenom, nom, age)
        {
            NumeroEmploye = numEmploye;
            Console.WriteLine("Constructeur d'Employe avec paramètre");
        }
        public void DireInformationEmployer()
        {
            DireBonjour();
            Console.WriteLine("Mon numéro d'employé est: " + NumeroEmploye);
        }

        public int NumeroEmploye { get; protected set; }
    }


    class Enseignant : Employe
    {
        public Enseignant()
        {
            Console.WriteLine("Constructeur par défaut d'Enseignant");
        }

        public Enseignant(string prenom, string nom, int age, int numEmploye, string cours) :
            base(prenom, nom, age, numEmploye) // Constructeur employer
        {
            // NumeroEmploye = NumEmploye;
            Console.WriteLine("Constructeur d'Enseignant avec paramètre");
            _nomCours = cours;
        }

        public void DireInformationEnseignant()
        {
            DireInformationEmployer();
            Console.WriteLine("J'enseigne " + _nomCours);
        }


        private string _nomCours;

    }

    class Chauffeur : Employe
    {

    }
}
