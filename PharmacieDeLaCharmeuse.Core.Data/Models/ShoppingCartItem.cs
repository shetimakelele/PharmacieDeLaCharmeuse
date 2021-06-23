using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemId { get; set; }

        public Produit Produit { get; set; }

        public int Amount { get; set; }

        public String ShoppingCartSessionId { get; set; }
    }
}
