using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Session
    {
        [Key]
        public int SessionId { get; set; }

        public string UserId { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
    }
}
