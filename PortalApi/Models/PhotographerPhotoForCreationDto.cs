using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PhotographerPhotoForCreationDto
    {
        [Required]
        public int? UserId { get; set; }
        [Required]
        public int? ModelingStyle { get; set; }
        [Required]
        [MaxLength(150)]
        public string ImgSrc { get; set; }
    }
}
