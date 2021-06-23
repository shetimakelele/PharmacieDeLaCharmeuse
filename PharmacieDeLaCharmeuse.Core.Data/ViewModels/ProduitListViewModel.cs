using PharmacieDeLaCharmeuse.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.ViewModels
{
     public  class ProduitListViewModel
    {
        public IEnumerable<Produit> Produits { get; set; }
    }

}
