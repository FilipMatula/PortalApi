using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(80)]
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        [MaxLength(150)]
        public string City { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }

        //Profiles
        public Model Model { get; set; }
        public Tattooer Tattooer { get; set; }
        public Piercer Piercer { get; set; }
        public Photographer Photographer { get; set; }

        //Photos
        public List<ModelPhoto> ModelPhotos { get; set; } = new List<ModelPhoto>();
        public List<Tattoo> Tattoos { get; set; } = new List<Tattoo>();
        public List<AvailableDesign> AvailableDesigns { get; set; } = new List<AvailableDesign>();
        public List<PhotographerPhoto> PhotographerPhotos { get; set; } = new List<PhotographerPhoto>();
        public List<Piercing> Piercings { get; set; } = new List<Piercing>();
    }
}
