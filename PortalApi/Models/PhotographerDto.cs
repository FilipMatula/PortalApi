using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PhotographerDto
    {
        public PersonDto Person { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string About { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
        public string Media { get; set; }
    }
}
