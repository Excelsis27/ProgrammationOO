using System;

namespace Debogueur
{
   /// <summary>
   /// Classe principale du programme
   /// </summary>
   class Program
   {
      static void Main()
      {
         Program p = new Program();
         p.Executer();
         Pause();
      }

      /// <summary>
      /// Arrête l'exécution pour permettre la lecture de la console
      /// </summary>
      public static void Pause()
      {
         Console.WriteLine("Appuyez sur une touche pour continuer...");
         Console.ReadKey(true);
      }

      private string AfficherMenu()
      {
         Console.Clear();
         Console.WriteLine("Papeterie Du Coin\n-----------------");
         Console.WriteLine("I) Afficher inventaire");
         Console.WriteLine("F) Créer facture");
         Console.WriteLine("Q) Quitter");
         Console.Write("\nVotre choix > ");

         return Console.ReadLine().ToUpper();
      }

      // Gère le choix de l'utilisateur
      private void Executer()
      {
         string choix = AfficherMenu();
         switch (choix)
         {
            case "I":
               _magasin.AfficherInventaire();
               Executer();
               break;
            case "F":
               _magasin.CreerFacture();
               Executer();
               break;
            case "Q":
               return;
            default:
               Console.WriteLine("Choix invalide");
               Pause();
               Executer();
               break;
         }
      }

      private Magasin _magasin = new Magasin();
   }
}
