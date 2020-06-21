using PortalApi.ProfilesProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Tattooer
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        [MaxLength(50)]
        public string Studio { get; set; }
        [MaxLength(1500)]
        public string About { get; set; }
        [MaxLength(150)]
        public string MediaFB { get; set; }
        [MaxLength(150)]
        public string MediaInstagram { get; set; }
        [MaxLength(150)]
        public string MediaTwitter { get; set; }
        public TattooStyle TattooStyle { get; set; }
        public Experience Experience { get; set; }
        public Technique Technique { get; set; }
    }
}
