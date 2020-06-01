using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        //public string  City { get; set; }
        //public string Gender { get; set; }
    }
}
