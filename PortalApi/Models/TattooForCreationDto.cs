using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class TattooForCreationDto
    {
        [Required]
        public int? TattooStyle { get; set; }
        [Required]
        public int? Color { get; set; }
        [Required]
        public int? Technique { get; set; }
        [Required]
        [MaxLength(150)]
        public string ImgSrc { get; set; }
    }
}
