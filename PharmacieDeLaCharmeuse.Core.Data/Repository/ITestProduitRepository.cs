using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Repository
{
    public interface ITestProduitRepository
    {
        IEnumerable<TestProduit> GetAllTestProduits();

        TestProduit GetTestProduitById(int id);
    }
}
