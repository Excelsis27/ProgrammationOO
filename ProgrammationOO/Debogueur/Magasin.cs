using System;
using System.Collections.Generic;

namespace Debogueur
{
   /// <summary>
   /// Gestionnaire d'un magasin
   /// </summary>
   class Magasin
   {
      /// <summary>
      /// Constructeur, définit les produits vendus
      /// </summary>
      public Magasin()
      {
         _produits.Add(new Produit("Stylo à bille", 149, 300));
         _produits.Add(new Produit("Gomme à effacer", 75, 25));
         _produits.Add(new Produit("Marqueurs Sharpie (paq 3)", 899, 60));
         _produits.Add(new Produit("Bâton de colle", 369, 20));
         _produits.Add(new Produit("Cahier spirale", 249, 10));
         _produits.Add(new Produit("Agrafeuse", 999, 5));
         _produits.Add(new Produit("Papier copie lettre (500)", 611, 10));
         _produits.Add(new Produit("Surligneur (paq 5)", 339, 100));
      }

      /// <summary>
      /// Affiche tous les produits vendus et leur quantité en inventaire
      /// </summary>
      public void AfficherInventaire()
      {
         string format = "{0,10}  {1,-30}{2,15:C}";
         Console.WriteLine(format, "Quantité", "Produit", "Prix unitaire");
         Console.WriteLine("--------------------------------------------------------------------------------");
         foreach (var item in _produits)
         {
            Console.WriteLine(format, item.Inventaire, item.Description, item.Prix / 100.0);
         }

         Console.WriteLine();
         Program.Pause();
      }

      /// <summary>
      /// Crée une nouvelle facture
      /// </summary>
      public void CreerFacture()
      {
         Facture facture = new Facture();

         // On boucle tant que l'utilisateur n'indique pas de terminer
         while (true)
         {
            // Affiche la liste des produits
            Console.Clear();
            Console.WriteLine("Choisir produit, ou 'T' pour terminer");
            for (int i = 0; i < _produits.Count; ++i)
            {
               Console.WriteLine("{0}) {1}", i, _produits[i].Description);
            }
            Console.Write("\nChoix: ");

            string choix = Console.ReadLine().ToUpper();
            // "T" indique que la sélection des produits est terminée
            if (choix == "T")
            {
               break;
            }

            // Gère le choix de l'utilisateur
            ChoisirProduit(choix, facture);
         }

         // Affiche la nouvelle facture
         Console.Clear();
         facture.Afficher();
         Program.Pause();
      }

      // Permet de gérer le choix de l'utilisateur lors de la sélection d'un produit
      // à ajouter à une facture
      private void ChoisirProduit(string choix, Facture f)
      {
         try
         {
            // Le choix doit être un index valide
            int choixEntier = Convert.ToInt32(choix);
            if (choixEntier < 0 || choixEntier >= _produits.Count)
            {
               throw new ArgumentException();
            }

            Console.Write("Quantité: ");
            int quantite = Convert.ToInt32(Console.ReadLine());
            if (quantite <= 0)
            {
               throw new ArgumentException();
            }

            // L'inventaire doit être suffisant
            if (quantite <= _produits[choixEntier].Inventaire)
            {
               f.AjouterAchat(_produits[choixEntier], quantite);
               // Met à jour l'inventaire du produit
               _produits[choixEntier].Inventaire -= quantite;
            }
            else
            {
               Console.WriteLine("Inventaire insuffisant");
               Program.Pause();
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine("Choix invalide");
            Program.Pause();
         }
      }


      private List<Produit> _produits = new List<Produit>();
   }
}
