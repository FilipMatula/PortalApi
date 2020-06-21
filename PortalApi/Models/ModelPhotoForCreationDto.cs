using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ModelPhotoForCreationDto
    {
        [Required]
        public int? ModelingStyle { get; set; }
        [Required]
        public BodyDecorationsDto BodyDecorations { get; set; }
        [Required]
        [MaxLength(150)]
        public string ImgSrc { get; set; }
    }
}
