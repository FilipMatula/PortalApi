using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ResourceParameters
{
    public class TattoosResourceParameters : PaginationResourceParameters
    {
        public string City { get; set; } = null;
        public string Style { get; set; } = null;
        public string Color { get; set; } = null;
        public string Technique { get; set; } = null;
        public string Gender { get; set; } = null;
    }
}
