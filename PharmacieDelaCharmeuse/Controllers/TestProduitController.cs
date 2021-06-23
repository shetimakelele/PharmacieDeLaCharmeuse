using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PharmacieDeLaCharmeuse.Core.Data;
using PharmacieDeLaCharmeuse.Core.Data.Models;
using PharmacieDeLaCharmeuse.Core.Data.Repository;

namespace PharmacieDelaCharmeuse.Controllers
{
    public class TestProduitController : Controller
    {
        private readonly ITestProduitRepository _testProduitRepository;


        // constructeur
        public TestProduitController(ITestProduitRepository testproduitRepository)
        {
            _testProduitRepository = testproduitRepository;
            
        }

        public IActionResult ListTestProduit()
        {
            var listTestProduit = _testProduitRepository.GetAllTestProduits();

            return View(listTestProduit);
        }

        public IActionResult Details(int TestProduitId)
        {
            var testproduit = _testProduitRepository.GetTestProduitById(TestProduitId);

            if (testproduit == null)
                return NotFound();
            return View(testproduit);
        }

    }
}