using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ResourceParameters
{
    public class PiercingsResourceParameters : PaginationResourceParameters
    {
        public List<string> Cities { get; set; } = null;
        public List<string> Punctures { get; set; } = null;
        public List<string> Genders { get; set; } = null;
    }
}
