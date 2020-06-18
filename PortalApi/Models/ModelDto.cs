using PortalApi.ProfilesProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ModelDto
    {
        public int Id { get; set; }
        public UserDto User { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Breast { get; set; }
        public int Waist { get; set; }
        public int Hip { get; set; }
        public string About { get; set; }
        public string MediaFB { get; set; }
        public string MediaInstagram { get; set; }
        public string MediaTwitter { get; set; }
        public BodyDecorations BodyDecorations { get; set; }
    }
}
