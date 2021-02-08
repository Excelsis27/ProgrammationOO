using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    class Rectangle
    {
        // Accesseur (getter)
        public int GetLargeur()
        {
            return _largeur;
        }
        public int GetHauteur()
        {
            return _hauteur;
        }

        // Mutateur (setter)
        public void SetLargeur(int value)
        {
            // La largeur ne peut pas être négative, ni nulle
            if (value > 0)
            {
                _largeur = value;
            }
        }
        public void SetHauteur(int value)
        {
            // La largeur ne peut pas être négative, ni nulle
            if (value > 0)
            {
                _hauteur = value;
            }
        }

        private int _largeur = 0;
        private int _hauteur = 0;
    }
}
