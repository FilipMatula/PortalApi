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
        public List<string> Experiences { get; set; } = null;
        public bool? Puncture { get; set; } = null;
        public bool? Tattoo { get; set; } = null;
        public List<string> ModelingStyles { get; set; } = null;
        public int? AgeFrom { get; set; } = null;
        public int? AgeTo { get; set; } = null;
        public int? HeightFrom { get; set; } = null;
        public int? HeightTo { get; set; } = null;
        public int? WeightFrom { get; set; } = null;
        public int? WeightTo { get; set; } = null;
        public int? BreastFrom { get; set; } = null;
        public int? BreastTo { get; set; } = null;
        public int? WaistFrom { get; set; } = null;
        public int? WaistTo { get; set; } = null;
        public int? HipFrom { get; set; } = null;
        public int? HipTo { get; set; } = null;
    }
}
