﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class TattooThumbnailDto
    {
        public int Id { get; set; }
        public TattooerShortDto Tattooer { get; set; }
        public string ImgSrc { get; set; }
    }
}
