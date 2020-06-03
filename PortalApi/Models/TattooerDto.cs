using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class TattooerDto
    {
        public int Id { get; set; }
        public PersonDto Person { get; set; }
        public string City { get; set; }
        public Gender Gender { get; set; }
        public string Studio { get; set; }
        public string About { get; set; }
        public string MediaFB { get; set; }
        public string MediaInstagram { get; set; }
        public string MediaTwitter { get; set; }
        public Style Styles { get; set; }
        public Experience Experience { get; set; }
        public string ImgSrc { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
