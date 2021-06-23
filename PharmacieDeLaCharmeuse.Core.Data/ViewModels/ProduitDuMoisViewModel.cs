using PharmacieDeLaCharmeuse.Core.Data.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.ViewModels
{
    public class ProduitDuMoisViewModel
    {
        public IEnumerable<Produit> ProduitDuMois { get; set; }
    }
}
