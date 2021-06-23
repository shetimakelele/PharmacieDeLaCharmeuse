using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Models
{
    [Table("Produit")]
    public class Produit
    {
        #region Proprietes
        [Key]
        public int ProduitId { get; set; }

        public string Nom { get; set; }

        public string DescriptionCourte { get; set; }

        public string DescriptionLongue { get; set; }

        public decimal Prix { get; set; }

        public decimal PrixPromo { get; set; }

        public int EnStock { get; set; }

        public bool ProduitDuMois { get; set; }

        public string ImageUrL { get; set; }

        public int CategorieProduitId { get; set; }

        public virtual CategorieProduit categorieProduit { get; set; }
               
        #endregion
    }
}
