using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PiercingDto
    {
        public PiercerShortDto Piercer { get; set; }
        public string Puncture { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
    }
}
