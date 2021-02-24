using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Etudiant : Personne
    {
        public Etudiant() // : base()
        {
            Console.WriteLine("Constructeur par défaut d'Étudiant");
        }

        public Etudiant(string prenom, string nom, int age, int matricule) :
            base(prenom, nom, age)
        {
            Console.WriteLine("Constructeur avec paramètre d'Étudiant");
            //Prenom = prenom;
            //Nom = nom;
            //Age = age;
            Matricule = matricule;
        }

        public Personne Moi { get; set; }
        public int Matricule { get; set; }
    }
}
