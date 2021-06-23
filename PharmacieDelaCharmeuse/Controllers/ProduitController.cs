using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PharmacieDeLaCharmeuse.Core.Data.Repository;


namespace PharmacieDelaCharmeuse.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitRepository _produitRepository;
        private readonly ICategorieProduitRepository _categorieProduitRepository;

        // constructeur
        public ProduitController(IProduitRepository produitRepository, ICategorieProduitRepository categorieProduitRepository)
        {
            _produitRepository = produitRepository;
            _categorieProduitRepository = categorieProduitRepository;
        }



        public IActionResult ListProduit()
        {
            var produitList = _produitRepository.GetAllProduits();
            
            return View(produitList);
        }

        public IActionResult Details(int ProduitId)
        {
            var produit = _produitRepository.GetProduitById(ProduitId);

            if (produit == null)
                return NotFound();
            return View( produit);
        }



    }
}
