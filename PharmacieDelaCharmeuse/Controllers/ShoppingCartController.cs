using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PharmacieDeLaCharmeuse.Core.Data.Migrations;
using PharmacieDeLaCharmeuse.Core.Data.Repository;
using PharmacieDeLaCharmeuse.Core.Data.ViewModels;
using PharmacieDeLaCharmeuse.Core.Data.Models;
using ShoppingCart = PharmacieDeLaCharmeuse.Core.Data.Models.ShoppingCart;

namespace PharmacieDelaCharmeuse.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProduitRepository _produitRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController (IProduitRepository produitRepository, ShoppingCart shoppingCart)
        {
            _produitRepository = produitRepository;
            _shoppingCart = shoppingCart;
        }
        //affiche recap commande
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel();
            shoppingCartViewModel.ShoppingCart = _shoppingCart;
            shoppingCartViewModel.shoppingCartTotal = _shoppingCart.GetshoppingCartTotal();

            return View(shoppingCartViewModel);
        }

        // ajout produit au panier
        public RedirectToActionResult AddToShoppingCart (int ProduitId)
        {
            var produit = _produitRepository.GetProduitById(ProduitId);
            if (produit != null)
            {
                _shoppingCart.AddToCart(produit, 1);
            }
            return RedirectToAction("Index");
        }

        // supression produit au panier
        public RedirectToActionResult RemoveFromShoppingCart(int ProduitId)
        {
            var produit = _produitRepository.GetProduitById(ProduitId);
            if (produit != null)
            {
                _shoppingCart.RemoveFromCart(produit);
            }
            return RedirectToAction("Index");
        }

    }
}
