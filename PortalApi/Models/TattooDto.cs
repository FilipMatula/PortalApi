using PortalApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class TattooDto
    {
        public Person Person { get; set; }
        public string Style { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
    }
}
