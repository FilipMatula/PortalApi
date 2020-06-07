using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Photographer
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

        //TODO tagi z maxmodels
        public List<Tuple<string, bool>> JobTags = new List<Tuple<string, bool>> 
        { 
            new Tuple<string, bool>("Fushion", false ),
            new Tuple<string, bool>("Portret", false ),
            new Tuple<string, bool>("Glamour", false ),
            new Tuple<string, bool>("Akt", false ),
            new Tuple<string, bool>("Edytorial", false ),
            new Tuple<string, bool>("Nagość zakryta", false ),
            new Tuple<string, bool>("Make up", false ),
            new Tuple<string, bool>("Stylizacja", false ),
        };

        [MaxLength(150)]
        public string ImgSrc { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
    }
}
