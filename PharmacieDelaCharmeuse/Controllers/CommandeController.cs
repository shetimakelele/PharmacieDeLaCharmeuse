using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PharmacieDeLaCharmeuse.Core.Data.Models;
using PharmacieDeLaCharmeuse.Core.Data.Repository;

namespace PharmacieDelaCharmeuse.Controllers
{
    public class CommandeController : Controller
    {
        private readonly ICommandeRepository _commandeRepository;
        private readonly ShoppingCart _shoppingCart;

        public CommandeController (ICommandeRepository commandeRepository, ShoppingCart shoppingCart)
        {
            _commandeRepository = commandeRepository;
            _shoppingCart       = shoppingCart;
        }

        [HttpGet]
        public IActionResult CreateCommande()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCommande(Commande commande)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Votre panier es vide, Remplissez le d'abordds"); // si panier vide
            }
            if (ModelState.IsValid) // teste si formulaire valide, on cree une commande
            {
                _commandeRepository.CreateCommande(commande);
                _shoppingCart.ClearPanier();

            }
            return View(commande);
        }
        public IActionResult ConfirmeCommande()
        {
            return View();
        }

        public IActionResult ListCommande()
        {
            var commandeList = _commandeRepository.GetAllCommandes();

            return View(commandeList);
        }
    }
}
