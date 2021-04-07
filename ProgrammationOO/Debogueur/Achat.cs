namespace Debogueur
{
   /// <summary>
   /// Contient un produit et une quantitée qui sont ajoutés à une facture
   /// </summary>
   class Achat
   {
      /// <summary>
      /// Constructeur
      /// </summary>
      /// <param name="article">Le produit acheté</param>
      /// <param name="quantite">La quantité achetée</param>
      public Achat(Produit article, int quantite)
      {
         Article = article;
         Quantite = quantite;
      }

      public int Quantite { get; }
      public Produit Article { get; }
      public int Montant { get { return Article.Prix * Quantite; } }
   }
}
