using System;
using System.Collections.Generic;

namespace Debogueur
{
   /// <summary>
   /// Représentation d'une facture du magasin
   /// </summary>
   class Facture
   {
      /// <summary>
      /// Constructeur
      /// </summary>
      public Facture()
      {
         _numero = _prochainNumero++;  // Post-incrémentation
         _date = DateTime.Today;
      }

      /// <summary>
      /// Ajouter un achat à la facture
      /// </summary>
      /// <param name="article">Le produit acheté</param>
      /// <param name="quantite">La quantité achetée</param>
      public void AjouterAchat(Produit article, int quantite)
      {
         Achat a = new Achat(article, quantite);
         _achats.Add(a);
         _sousTotal += a.Montant;
      }

      /// <summary>
      /// Affiche le contenu de la facture
      /// </summary>
      public void Afficher()
      {
         Console.WriteLine("Facture #{0,-25}Date: {1}\n", _numero, _date.ToShortDateString());

         string format = "{0,10}  {1,-30}{2,15:C}{3,10:C}";
         Console.WriteLine(format, "Quantité", "Produit", "Prix unitaire", "Prix");

         Console.WriteLine("--------------------------------------------------------------------------------");
         foreach (var item in _achats)
         {
            Console.WriteLine(format, item.Quantite, item.Article.Description, item.Article.Prix / 100.0, item.Montant / 100.0);
         }
         Console.WriteLine("--------------------------------------------------------------------------------");

         Console.WriteLine("{0,55}: {1,10:C}", "Sous-total", _sousTotal / 100.0);
      }

      // Pour attribution d'un numéro unique à chaque facture
      private static int _prochainNumero = 1;

      private readonly int _numero;
      private readonly DateTime _date;
      private List<Achat> _achats = new List<Achat>();
      private double _sousTotal = 0;
   }
}
