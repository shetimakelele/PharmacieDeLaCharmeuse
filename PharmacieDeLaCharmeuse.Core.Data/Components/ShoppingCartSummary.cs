using Microsoft.AspNetCore.Mvc;
using PharmacieDeLaCharmeuse.Core.Data.Models;
using PharmacieDeLaCharmeuse.Core.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel();
            shoppingCartViewModel.ShoppingCart = _shoppingCart;
            shoppingCartViewModel.shoppingCartTotal = _shoppingCart.GetshoppingCartTotal();
            return View(shoppingCartViewModel);
        }
    }
}


