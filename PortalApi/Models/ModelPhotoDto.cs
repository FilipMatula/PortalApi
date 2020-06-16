using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ModelPhotoDto
    {
        public int Id { get; set; }
        public UserShortDto User { get; set; }
        public string ModelingStyle { get; set; }
        public BodyDecorationsDto BodyDecorations { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
    }
}
