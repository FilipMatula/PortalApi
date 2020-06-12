using PortalApi.ProfilesProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class TattooerDto
    {
        public int Id { get; set; }
        public UserShortDto User { get; set; }
        public string Studio { get; set; }
        public string About { get; set; }
        public string MediaFB { get; set; }
        public string MediaInstagram { get; set; }
        public string MediaTwitter { get; set; }
        public TattooStyle Styles { get; set; }
        public Experience Experience { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
