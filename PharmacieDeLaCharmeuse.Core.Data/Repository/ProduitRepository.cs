using Microsoft.EntityFrameworkCore;
using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PharmacieDeLaCharmeuse.Core.Data.Repository
{
    public class ProduitRepository : IProduitRepository
    {
        private readonly DefaultContext _context;

        #region Constructeurs
        public  ProduitRepository (DefaultContext context)
        {
            this._context = context;
        }
        #endregion

        public IEnumerable<Produit> ProduitsDuMois => _context.Produits.Where(p => p.ProduitDuMois).Include(c => c.categorieProduit);

        
        public IEnumerable<Produit> GetAllProduits()
        {
            return _context.Produits.Include(c => c.categorieProduit);
        }

        public Produit GetProduitById(int id)
        {
            return _context.Produits.FirstOrDefault( p => p.ProduitId == id);
        }
    }
}
