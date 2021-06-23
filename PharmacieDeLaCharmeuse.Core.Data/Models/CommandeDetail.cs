using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Models
{
    public class CommandeDetail
    {
        [Key]
        public  int CommandeDetailId { get; set; }

        public int ProduitId { get; set; }

        public int Amount { get; set; }

        public decimal Prix { get; set; }

        public  Produit Produit { get; set; }

        [ForeignKey("Commande")]
        public int CommandeId { get; set; }

        public Commande Commande { get; set; }
    }
}
