using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ResourceParameters
{
    public class PiercingsResourceParameters : PaginationResourceParameters
    {
        public string City { get; set; } = null;
        public string Puncture { get; set; } = null;
        public string Gender { get; set; } = null;
    }
}
