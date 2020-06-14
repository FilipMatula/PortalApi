using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PiercingForCreationDto
    {
        [Required]
        public int? UserId { get; set; }
        [Required]
        public int? Puncture { get; set; }
        [Required]
        [MaxLength(150)]
        public string ImgSrc { get; set; }
    }
}
