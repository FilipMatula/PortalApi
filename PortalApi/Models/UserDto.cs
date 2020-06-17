using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string ImgSrc { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
