using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PharmacieDeLaCharmeuse.Core.Data.Repository
{
    public class CommandeRepository : ICommandeRepository
    {
        private readonly DefaultContext _context;

        private readonly ShoppingCart _shoppingCart;

        #region Constructeurs
        public CommandeRepository(DefaultContext context, ShoppingCart shoppingCart)
        {
            this._context = context;
            _shoppingCart = shoppingCart;
        }
        #endregion
        public void CreateCommande(Commande commande)
        {
            commande.DateCommande = DateTime.Now;
            var items = _shoppingCart.GetShoppingCartItems();
            commande.CommandeTotal = _shoppingCart.GetshoppingCartTotal();
            commande.CommandeDetails = new List<CommandeDetail>();
            foreach (var item in items)
            {
                var commandeDetail = new CommandeDetail
                {
                    ProduitId = item.Produit.ProduitId,
                    Amount = item.Amount,
                    Prix = item.Produit.Prix

                };

                commande.CommandeDetails.Add(commandeDetail);
               
            }
            _context.Commandes.Add(commande);
            _context.SaveChanges();
        }

        public IEnumerable<Commande> GetAllCommandes()
        {
            return _context.Commandes;
        }

        public Commande GetComandeById(int id)
        {
            return _context.Commandes.FirstOrDefault(com => com.CommandeId == id);
        }
    }
}
