using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ResourceParameters
{
    public class PhotographerResourceParameters : PaginationResourceParameters
    {
        public string City { get; set; } = null;
        public string Experience { get; set; }
        public string Gender { get; set; } = null;
    }
}
