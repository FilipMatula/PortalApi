using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        public Person Person { get; set; }
        [Required]
        public int PersonId { get; set; }
        [MaxLength(150)]
        public string City { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [MaxLength(1500)]
        public string About { get; set; }
        [MaxLength(150)]
        public string MediaFB { get; set; }
        [MaxLength(150)]
        public string MediaInstagram { get; set; }
        [MaxLength(150)]
        public string MediaTwitter { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
    }
}
