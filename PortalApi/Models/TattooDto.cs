using PortalApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class TattooDto
    {
        public int Id { get; set; }
        public UserShortDto User { get; set; }
        public string TattooStyle { get; set; }
        public string Color { get; set; }
        public string Technique { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
    }
}
