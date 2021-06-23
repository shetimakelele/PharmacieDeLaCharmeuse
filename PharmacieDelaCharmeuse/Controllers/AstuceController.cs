using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmacieDeLaCharmeuse.Core.Data;
using PharmacieDeLaCharmeuse.Core.Data.Models;
using PharmacieDeLaCharmeuse.Core.Data.Repository;

namespace PharmacieDelaCharmeuse.Controllers
{
    public class AstuceController : Controller
    {
        private readonly IAstuceRepository _astuceRepository;
        

        // constructeur
        public AstuceController(IAstuceRepository astuceRepository )
        {
            _astuceRepository = astuceRepository;
           
        }

        public IActionResult ListAstuce()
        {
            var astuceList = _astuceRepository.GetAllAstuces();

            return View(astuceList);
        }

        public IActionResult Details(int AstuceId)
        {
            var astuce = _astuceRepository.GetAstuceById(AstuceId);

            if (astuce == null)
                return NotFound();

            return View(astuce);
        }
    }
}