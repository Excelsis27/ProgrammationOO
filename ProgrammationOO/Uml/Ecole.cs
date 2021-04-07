using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml
{
    class Ecole
    {
        public Ecole(string nom)
        {
            Nom = nom;

            Departement informatique = new Departement("Techniques Informatique", this);
            _tousLesDepartements.Add(informatique);
            Departement juridique = new Departement("Techniques juridique", this);
            _tousLesDepartements.Add(juridique);

            informatique.EmbaucherEnseignant();
            juridique.EmbaucherEnseignant();
        }

        public string Nom { get; }

        public void InscrireEtudiant()
        {
            // Ajouterait les infos de l'étudiant ici en le créant
            // this représente l'école qui inscrit l'étudiant
            Etudiant e = new Etudiant(this);
            _tousLesEtudiants.Add(e);
        }
        public void AjouterEtudiant(Etudiant e)
        {
            // Si l'appel: cstj.AjouterEtudiant(...)
            // alors: this == cstj
            this._tousLesEtudiants.Add(e);
            // Équivalent à
            // _tousLesEtudiants.Add(e);

        }


        private List<Etudiant> _tousLesEtudiants = new List<Etudiant>();
        private List<Departement> _tousLesDepartements = new List<Departement>();
    }
    class Etudiant : Personne
    {
        public Etudiant(Ecole ecole)
        {
            _ecole = ecole;
        }

        private Ecole _ecole;
        private List<Groupe> _groupes;
    }

    class Departement
    {
        public Departement(string nom, Ecole ecole)
        {
            Nom = nom;
            _ecole = ecole;
        }
        public string Nom { get; }

        public void EmbaucherEnseignant()
        {
            Console.WriteLine("Donnez le nom de l'enseignant embauché dans le département {0} de l'école {1}: ", Nom, _ecole.Nom);
            // Si appel: imformatique.EmbaucherEnseignant() alors this == informatique
            Enseignant e = new Enseignant(Console.ReadLine(), this);
            _lesEnseignants.Add(e);
        }

        private Ecole _ecole;
        private List<Cours> _coursOfferts;
        private List<Enseignant> _lesEnseignants = new List<Enseignant>();
        private Enseignant _coordonnateur;
    }
    class Cours
    {
        private Departement _departement;
        private List<Groupe> _groupes;
    }

    class Groupe
    {
        private Cours _cours;
        private List<Etudiant> _etudiants;
        private List<Enseignant> _enseignants;
    }

    class Enseignant : Personne
    {
        public Enseignant(string nom, Departement d)
        {
            Nom = nom;
            _departement = d;
        }
        
        public string Nom { get; }

        private Departement _departement;
        private List<Groupe> _groupesEnseignes;
        private bool _estCoordonnateur;
    }

    class Personne
    {

    }
}
