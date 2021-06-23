using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PharmacieDeLaCharmeuse.Core.Data.Repository;

namespace PharmacieDelaCharmeuse.Controllers
{
    public class CategorieProduitController : Controller
    {
        private readonly IProduitRepository _produitRepository;
        private readonly ICategorieProduitRepository _categorieProduitRepository;

        // constructeur
        public CategorieProduitController(IProduitRepository produitRepository, ICategorieProduitRepository categorieProduitRepository)
        {
            _produitRepository = produitRepository;
            _categorieProduitRepository = categorieProduitRepository;
        }

        public IActionResult ListCategorieProduit()
        {
            var categorieproduitList = _categorieProduitRepository.GetAllCategorieProduits();

            return View(categorieproduitList);
        }

        public IActionResult CreerCategorie()
        {
            return View();
        }
    }
}
