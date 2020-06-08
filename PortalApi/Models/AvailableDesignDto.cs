﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class AvailableDesignDto
    {
        public TattooerShortDto Tattooer { get; set; }
        public string Style { get; set; }
        public string Color { get; set; }
        public string Technique { get; set; }
        public double? Price { get; set; }
        public bool Reserved { get; set; }
        public string ImgSrc { get; set; }
        public string FormattedDate { get; set; }
    }
}
