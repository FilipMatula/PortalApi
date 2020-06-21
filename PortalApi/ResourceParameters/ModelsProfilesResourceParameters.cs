using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ResourceParameters
{
    public class ModelsProfilesResourceParameters : PaginationResourceParameters
    {
        public List<string> Genders { get; set; } = null;
        public List<string> Cities { get; set; } = null;

        public int? AgeFrom { get; set; } = null;
        public int? AgeTo { get; set; } = null;

    }
}
