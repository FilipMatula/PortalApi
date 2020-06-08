using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class AvailableDesignThumbnailDto
    {
        public int Id { get; set; }
        public TattooerShortDto Tattooer { get; set; }
        public double? Price { get; set; }
        public bool Reserved { get; set; }
        public string ImgSrc { get; set; }
    }
}
