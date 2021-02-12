using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    class Horloge
    {
        public Horloge()
        {
            _secondes = Secondes;
            Console.WriteLine("trace constructeur horloge sans paramètre");

        }
        public Horloge(int heures)
        {
            Console.WriteLine("trace constructeur horloge avec paramètre heures");
        }
        public Horloge(int heures, int minutes)
        {
            Console.WriteLine("trace constructeur horloge avec paramètre heures, minutes");
        }
        public Horloge(int heures, int minutes, int secondes)
        {
            Console.WriteLine("trace constructeur horloge avec paramètre heures, minutes, secondes");
        }

        // Propriétés Horloge

        public int Heures
        {
            get { return _secondes / 3600; }
        }
        public int Minutes
        {
            get { return _secondes / 60;  }
        }
        public int Secondes
        {
            get { return _secondes; }
        }

        public void Afficher()
        {
            Console.WriteLine();
        }

        public bool EstEgaleA(Horloge h)
        {
            return true;
        }



        private int _secondes;
    }
}
