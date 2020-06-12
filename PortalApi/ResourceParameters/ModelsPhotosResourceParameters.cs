using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ResourceParameters
{
    public class ModelsPhotosResourceParameters : PaginationResourceParameters
    {
        public List<string> Cities { get; set; } = null;
        public List<string> Genders { get; set; } = null;
        //TODO: Przemyslec czy tak czy inaczej
        public bool? Puncture { get; set; } = null;
        public bool? Tattoo { get; set; } = null;
        public List<string> Styles { get; set; } = null;
    }
}
