using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Models
{
    [Table("CategorieProduit")]
    public class CategorieProduit
    {
        [Key]
        public int CategorieProduitID { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        [Display(Name = " Nom")]
        public string NomCategorieProduit { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        [Display(Name = " Description")]
        public string DescriptionCategorieProduit { get; set; }

        public List<Produit> Produits { get; set; }
    }
}
