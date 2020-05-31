﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
    }
}
