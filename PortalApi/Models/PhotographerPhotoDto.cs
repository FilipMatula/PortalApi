using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PhotographerPhotoDto
    {
        public PhotographerShortDto Photographer { get; set; }
        public string Style { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
    }
}
