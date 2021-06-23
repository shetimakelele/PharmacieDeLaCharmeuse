using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Models
{
    public class ShoppingCart
    {
        private readonly  DefaultContext _context ;

        public String ShoppingCartSessionID { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(DefaultContext context)
        {
            _context = context;

        }

        public static ShoppingCart GetCart(IServiceProvider service)
        {
            // recuperer la session utilisateur
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<DefaultContext>();

            var sessionCart = session.GetString("CartIdSession") ?? Guid.NewGuid().ToString();

            session.SetString("CartIdSession", sessionCart);

            return new ShoppingCart(context) { ShoppingCartSessionID = sessionCart };

            
        }

        // Ajout dans le panier
        public void AddToCart( Produit produit, int amount)
        {
            var shoppingCartItem = _context.ShoppingCartItems.FirstOrDefault(Item => Item.ShoppingCartSessionId == ShoppingCartSessionID && Item.Produit.ProduitId == produit.ProduitId);

            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartSessionId = ShoppingCartSessionID,
                    Produit = produit,
                    Amount = 1

                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _context.SaveChanges();
        }

        //retrait dans le panier
        public int RemoveFromCart(Produit produit)
        {
            var shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(s => s.Produit.ProduitId == produit.ProduitId && s.ShoppingCartSessionId == ShoppingCartSessionID );

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _context.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                (ShoppingCartItems = _context.ShoppingCartItems.Where(c => c.ShoppingCartSessionId == ShoppingCartSessionID).Include(s => s.Produit).ToList());
        }

        public void ClearPanier()
        {
            var panierItems = _context.ShoppingCartItems.Where(cart => cart.ShoppingCartSessionId == ShoppingCartSessionID);
       

            _context.ShoppingCartItems.RemoveRange(panierItems);

            _context.SaveChanges();
        }

        public decimal GetshoppingCartTotal()
        {
            var total = _context.ShoppingCartItems.Where(c => c.ShoppingCartSessionId == ShoppingCartSessionID)
                .Select(c => c.Produit.Prix * c.Amount).Sum();
            return total;
        }
    }
}
