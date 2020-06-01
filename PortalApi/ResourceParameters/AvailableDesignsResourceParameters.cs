using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ResourceParameters
{
    public class AvailableDesignsResourceParameters : PaginationResourceParameters
    {
        public List<string> Cities { get; set; } = null;
        public List<string> Styles { get; set; } = null;
        public List<string> Colors { get; set; } = null;
        public List<string> Techniques { get; set; } = null;
        public List<string> Genders { get; set; } = null;
        public bool? Reserved { get; set; } = null;
        public bool? WithPrice { get; set; } = null;
        public double? PriceFrom { get; set; } = null;
        public double? PriceTo { get; set; } = null;
    }
}
