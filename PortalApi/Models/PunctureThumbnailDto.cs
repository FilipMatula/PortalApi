using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PunctureThumbnailDto
    {
        public int Id { get; set; }
        public PersonDto Person { get; set; }
        public string ImgSrc { get; set; }
    }
}
