using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class Studio
    {
        public int Id { get; set; }
        public string Profession { get; set; }
        public string City { get; set; }
        public string TelephoneNumber { get; set; }
        public string Page { get; set; }
        public string MediaFacebook { get; set; }
        public string MediaTwitter { get; set; }
        public string MediaInstagram { get; set; }
        public IList<Person> Squad { get; set; }

    }
}
