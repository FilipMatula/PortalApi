using Microsoft.EntityFrameworkCore;
using PortalApi.ProfilesProperties;
using System.ComponentModel.DataAnnotations;

namespace PortalApi.Entities
{
    public class Piercer
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
        //[Required]
        public Puncture Punctures { get; set; }
        [Required]
        public Experience Experience { get; set; }
    }
}
