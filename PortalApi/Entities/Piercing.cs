using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Piercing
    {
        [Key]
        public int Id { get; set; }
        public Piercer Piercer { get; set; }
        [Required]
        public int PiercerId { get; set; }
        [Required]
        public Puncture Puncture { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
