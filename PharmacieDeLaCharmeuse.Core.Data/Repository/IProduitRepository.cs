using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Repository
{
    public interface IProduitRepository
    {
        IEnumerable<Produit> GetAllProduits();

        IEnumerable<Produit> ProduitsDuMois { get; }

        Produit GetProduitById(int id);
    }
}
