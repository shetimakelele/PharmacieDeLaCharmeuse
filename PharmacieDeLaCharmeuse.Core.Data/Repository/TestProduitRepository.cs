using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Repository
{
    public class TestProduitRepository : ITestProduitRepository
    {
        private readonly DefaultContext _context;

        #region Constructeurs
        public TestProduitRepository(DefaultContext context)
        {
            this._context = context;
        }
        #endregion
        public IEnumerable<TestProduit> GetAllTestProduits()
        {
            return _context.TestProduits;
        }

        public TestProduit GetTestProduitById(int id)
        {
            return _context.TestProduits.FirstOrDefault(te => te.TestProduitId == id); // te => test
        }
    }
}
