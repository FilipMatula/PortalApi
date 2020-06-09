using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ModelPhotoDto
    {
        public UserShortDto User { get; set; }
        public string Style { get; set; }
        public bool Puncture { get; set; }
        public bool Tattoo { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
    }
}
