using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Description
    {
        [Key]
        public int Id { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
    }
}
