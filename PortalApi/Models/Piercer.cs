using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class Piercer : Person
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public int AssignedToStudioId { get; set; }
        public Studio Studio { get; set; }
    }
}
