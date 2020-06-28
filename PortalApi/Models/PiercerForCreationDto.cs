using PortalApi.ProfilesProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PiercerForCreationDto
    {      
        public string Studio { get; set; }
        [Required]
        public string About { get; set; }
        public string MediaFB { get; set; }
        public string MediaInstagram { get; set; }
        public string MediaTwitter { get; set; }
        [Required]
        public Puncture Punctures { get; set; }
        [Required]
        public Experience Experience { get; set; }
    }
}
