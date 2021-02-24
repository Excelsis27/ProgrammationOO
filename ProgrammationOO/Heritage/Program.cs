using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Prenom = "Alphonse";
            p1.Nom = "Cloutier";
            p1.Age = 42;
            Console.WriteLine("Personne 1: Prénom = {0}, Nom = {1}, Age = {2}", p1.Prenom, p1.Nom, p1.Age);
            p1.DireBonjour();

            Etudiant e1 = new Etudiant();
            e1.Prenom = "Joséphine";
            e1.Nom = "Boileau";
            e1.Age = 19;
            e1.Matricule = 1234567;
            Console.WriteLine("Étudiant 1: Prénom = {0}, Nom = {1}, Age = {2}, Matricule = {3}", e1.Prenom, e1.Nom, e1.Age, e1.Matricule);

            e1.DireBonjour();

            Console.WriteLine();

            Personne p2 = new Personne("Dolorès", "Archambault", 27);
            p2.DireBonjour();

            Etudiant e2 = new Etudiant("Bob", "Roy", 17, 123561);
            e2.DireBonjour();

            Console.WriteLine("Appuyez sur uen touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
