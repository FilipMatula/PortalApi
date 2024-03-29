﻿using PortalApi.ProfilesProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ResourceParameters
{
    public class PhotographersPhotosResourceParameters : PaginationResourceParameters
    {
        public List<string> Cities { get; set; } = null;
        public List<string> Experiences { get; set; } = null;
        public List<string> ModelingStyles { get; set; } = null;
    }
}
