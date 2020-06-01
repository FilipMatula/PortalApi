﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PhotographerPhotoDto
    {
        public PersonDto Person { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Experience { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
    }
}
