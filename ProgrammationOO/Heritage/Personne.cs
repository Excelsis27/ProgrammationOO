using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Personne
    {
        public Personne()
        {
            Console.WriteLine("Constructeur par défaut de Personne");
        }

        public Personne(string prenom, string nom, int age)
        {
            Console.WriteLine("Constructeur avec paramètre de Personne");
            Prenom = prenom;
            Nom = nom;
            Age = age;
        }

        // Propriétés d'une personne
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }

        public void DireBonjour()
        {
            Console.WriteLine("Bonjour, je m'appelle {0} {1}, j'ai {2} ans.", Prenom, Nom, Age);
        }
    }
}
