using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PhotographerPhotoThumbnailDto
    {
        public int Id { get; set; }
        public UserShortDto User { get; set; }
        public string ImgSrc { get; set; }
    }
}
