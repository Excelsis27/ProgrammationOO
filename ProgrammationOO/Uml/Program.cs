using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml
{
    class Program
    {
        static void Main(string[] args)
        {
            Ecole cstj = new Ecole("CEGEP de Saint-Jérôme");

            Etudiant e = new Etudiant(cstj);
            cstj.AjouterEtudiant(e);

            cstj.InscrireEtudiant();

            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);
        }
    }
}
