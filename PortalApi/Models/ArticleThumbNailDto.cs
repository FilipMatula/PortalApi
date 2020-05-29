using PortalApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ArticleThumbnailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgSrc { get; set; }
    }
}
