namespace Debogueur
{
   /// <summary>
   /// Représente un produit vendu par le magasin
   /// </summary>
   class Produit
   {
      /// <summary>
      /// Constructeur
      /// </summary>
      /// <param name="description">La description du produit</param>
      /// <param name="prix">Le prix unitaire</param>
      /// <param name="inventaire">La quantité en inventaire</param>
      public Produit(string description, int prix, int inventaire)
      {
         _description = description;
         _prix = prix;
         Inventaire = inventaire;
      }

      public string Description { get { return _description; } }
      public int Prix { get { return _prix; } }
      public int Inventaire { get; set; }


      private readonly string _description;
      private readonly int _prix;
   }
}
