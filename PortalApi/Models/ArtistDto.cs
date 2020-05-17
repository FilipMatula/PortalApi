using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ArtistDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string Mail { get; set; }
        public DescriptionDto Description { get; set; }
    }
}
