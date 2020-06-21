using PortalApi.ProfilesProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class User
    {
        // Basic information
        [Key]
        public int Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(80)]
        [Required]
        public string Username { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        // Additional
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(150)]
        public string City { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
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
