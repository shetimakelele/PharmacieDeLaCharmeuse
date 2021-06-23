using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Models
{
    [Table("Astuce")]
    public class Astuce
    {
        #region Proprietes

        [Key]
        public int AstuceId { get; set; }

      //  [Required( AllowEmptyStrings = false  ,ErrorMessage = "La date est requise")]
        public DateTime DateEdition { get; set; }

        [Required(AllowEmptyStrings = false ,ErrorMessage = "Le titre est requis")]
        public string Titre { get; set; }

        [Required(AllowEmptyStrings = false , ErrorMessage = "Ce champs est requis")]
        public string DescriptionCourte { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est requis")]
        public string Description { get; set; }

        public int ProduitId  { get; set; } // Suggestion article

        public string AstuceImageUrl { get; set; }
        #endregion
    }
}
