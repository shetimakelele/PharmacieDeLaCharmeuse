using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace PharmacieDeLaCharmeuse.Core.Data.Models
{
    [Table("Image")]
    public class ImageModel
    {
        [Key]
        public int ImageId { get; set; }

        public string TitreImage { get; set; }

        public string NomImage { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
