using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class PiercerThumbnailDto
    {
        public int Id { get; set; }

        public string Studio { get; set; }
        public UserShortDto User { get; set; }
    }
}
