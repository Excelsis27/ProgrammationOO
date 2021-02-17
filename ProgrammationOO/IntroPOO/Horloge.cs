using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    class Horloge
    {
        #region Inutile
        /*
        /// <summary>
        /// Représentation de l'heure du jour
        /// </summary>
        public Horloge()
        {
        }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="heures">Les heures de l'horloge</param>
        public Horloge(int heures)
        {
            if (heures >= 0 && heures <= 23)
            {
                _secondesTotales = heures * SecondesDansHeures;
            }
        }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="heures">Les heures de l'horloge</param>
        /// <param name="minutes">Les minutes de l'horloge</param>
        public Horloge(int heures, int minutes)
        {
            if (heures >= 0 && heures <= 23)
            {
                _secondesTotales = heures * SecondesDansHeures;
            }

            if (minutes >= 0 && minutes <= 59)
            {
                _secondesTotales += minutes * SecondesDansMinutes;
            }
        }*/
        #endregion
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="heures">Les heures de l'horloge</param>
        /// <param name="minutes">Les minutes de l'horloge</param>
        /// <param name="secondes">Les secondes de l'horloge</param>
        public Horloge(int heures = 0, int minutes = 0, int secondes = 0)
        {
            if (heures >= 0 && heures <= 23)
            {
                _secondesTotales = heures * SecondesDansHeures;
            }

            if (minutes >= 0 && minutes <= 59)
            {
                _secondesTotales += minutes * SecondesDansMinutes;
            }
            if (secondes >= 0 && secondes <= 59)
            {
                _secondesTotales += secondes;
            }
        }

        // Propriétés Horloge
        /// <summary>
        /// Récupère les valeurs distinctes de l'horloge
        /// </summary>
        public int Heures
        {
            // Accesseur
            get { return _secondesTotales / SecondesDansHeures; }

        }
        /// <summary>
        /// Récupère les valeurs distinctes de l'horloge
        /// </summary>
        public int Minutes
        {
            get { return (_secondesTotales % SecondesDansHeures) / SecondesDansMinutes; }
        }
        /// <summary>
        /// Récupère les valeurs distinctes de l'horloge
        /// </summary>
        public int Secondes
        {
            get { return _secondesTotales % SecondesDansMinutes; }
        }

        public void Afficher()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", Heures, Minutes, Secondes);
        }

        /// <summary>
        /// Compare la valeur de l'horloge avec une autre
        /// </summary>
        /// <param name="autreHorloge">L'horloge à comparé</param>
        /// <returns>Vrai si les horloges sont égales, faux sinon</returns>
        public bool EstEgaleA(Horloge autreHorloge)
        {
            // autreHorloge est une référence car c'est un objet. Il faut être prudent de ne pas faire de modification non voulues
            // autreHorloge._secondesTotales = 123;

            // Le niveau de protection (private) est au niveau de la classe, et non pas de l'objet
            // Il est donc possible d'accéder aux attributs privés d'un autre objet de la même classe
            return _secondesTotales == autreHorloge._secondesTotales;
        }

        private int SecondesDansHeures = 3600;
        private int SecondesDansMinutes = 60;

        // La valeur de l'horloge sous forme d'un nombre total de secondes
        private int _secondesTotales = 0;
    }
}
