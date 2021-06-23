using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PharmacieDelaCharmeuse.Models;
using PharmacieDeLaCharmeuse.Core.Data.Repository;
using PharmacieDeLaCharmeuse.Core.Data.ViewModels;

namespace PharmacieDelaCharmeuse.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IProduitRepository _produitRepository;

        public HomeController(IProduitRepository produitRepository)
        {
            _produitRepository = produitRepository;
        }

        public ViewResult Index()
        {
            var produitDuMoisViewModel = new ProduitDuMoisViewModel
            {
                ProduitDuMois = _produitRepository.ProduitsDuMois

            };
            return View(produitDuMoisViewModel);
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Reseau()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
