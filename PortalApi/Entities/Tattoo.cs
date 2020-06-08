using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Tattoo
    {
        [Key]
        public int Id { get; set; }
        public Tattooer Tattooer { get; set; }
        [Required]
        public int TattooerId { get; set; }
        [Required]
        public TattooStyle Style { get; set; }
        [Required]
        public Color Color { get; set; }
        [Required]
        public Technique Technique { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
