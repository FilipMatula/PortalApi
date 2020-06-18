using PortalApi.ProfilesProperties;
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
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public Experience Experience { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Breast { get; set; }
        public int Waist { get; set; }
        public int Hip { get; set; }
        [MaxLength(1500)]
        public string About { get; set; }
        //public List<JobTags> JobTags { get; set; } = new List<JobTags>();
        [MaxLength(150)]
        public string MediaFB { get; set; }
        [MaxLength(150)]
        public string MediaInstagram { get; set; }
        [MaxLength(150)]
        public string MediaTwitter { get; set; }
        public BodyDecorations BodyDecorations { get; set; }

    }
}
