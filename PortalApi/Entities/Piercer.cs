using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Piercer
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        [MaxLength(150)]
        [Required]
        public string City { get; set; }
        [Required]
        public Gender Gender { get; set; }
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
        public Puncture Punctures { get; set; }
        public Experience Experience { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        //[Required]
        public DateTime RegistrationDate { get; set; }
    }
}
