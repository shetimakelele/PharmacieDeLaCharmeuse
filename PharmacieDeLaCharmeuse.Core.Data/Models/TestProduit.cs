using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PharmacieDeLaCharmeuse.Core.Data.Models
{
    [Table("TestProduit")]
    public class TestProduit
    {
        #region Proprietes
        [Key]
        public int TestProduitId { get; set; }

        
        public DateTime DateEdition { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre est requis")]
        public string Titre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ce champs est requis")]
        public string DescriptionCourte { get; set; }

        [Required(ErrorMessage = "Ce champs est requis")]
        public string Description { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "La date est requise")]
        [Range(0,10)]
        public int NoteTest { get; set; }
        
        public string TestImageUrl { get; set; } // penser a corriger faute d 'ortho en migration

        #endregion
    }
}
