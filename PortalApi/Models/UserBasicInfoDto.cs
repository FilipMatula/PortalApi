using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class UserBasicInfoDto
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(150)]
        [Required]
        public string City { get; set; }
        [Required]
        public int? Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
    }
}
