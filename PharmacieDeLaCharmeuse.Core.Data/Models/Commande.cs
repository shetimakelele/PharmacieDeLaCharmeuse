using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Models
{
    public class Commande
    {
        [BindNever]
        [Key]
        public int CommandeId { get; set; }

        public List<CommandeDetail> CommandeDetails { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        [Display(Name = " Nom")]
        [StringLength(50)]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        [Display(Name = " Prénom")]
        [StringLength(50)]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        [Display(Name = " Adresse")]
        [StringLength(250)]
        public string Adresse1 { get; set; }

        public string Adresse2 { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        [Display(Name = " Code postal")]
        [StringLength(10, MinimumLength = 4)]
        public int CodePostal { get; set; }

        public string Ville { get; set; }

        public string Pays { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
      
        public string Email { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        [Display(Name = " Télephone")]
        [StringLength(50)]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [BindNever]
        public decimal CommandeTotal { get; set; }

        [BindNever]
        public DateTime DateCommande { get; set; }

    }
}
