using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ResourceParameters
{
    public class ModelPhotoResourceParameters : PaginationResourceParameters
    {
        public string City { get; set; } = null;
        public string Gender { get; set; } = null;
        public bool Piercing { get; set; }
        public bool Tattoo { get; set; }
    }
}
