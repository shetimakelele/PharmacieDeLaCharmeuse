using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Repository
{
    public class CategorieProduitRepository : ICategorieProduitRepository
    {
        private readonly DefaultContext _context;

        #region Constructeurs
        public CategorieProduitRepository(DefaultContext context)
        {
            this._context = context;
        }
        #endregion

        public IEnumerable<CategorieProduit> GetAllCategorieProduits()
        {
            return _context.CategorieProduits;
        }

        public CategorieProduit GetCategorieProduitById(int id)
        {
            return _context.CategorieProduits.FirstOrDefault(c => c.CategorieProduitID == id);
        }
    }
}
