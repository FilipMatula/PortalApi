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
        public Person Person { get; set; }
        [Required]
        public int PersonId { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public Style Style { get; set; }
        [MaxLength(50)]
        public Color Color { get; set; }
        [MaxLength(50)]
        public Technique Technique { get; set; }
        [MaxLength(50)]
        public Gender Gender { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
