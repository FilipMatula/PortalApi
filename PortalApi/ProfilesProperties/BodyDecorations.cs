using Microsoft.EntityFrameworkCore;
using PortalApi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.ProfilesProperties
{
    [Owned]
    public class BodyDecorations
    {
        [Required]
        public bool Puncture { get; set; }
        [Required]
        public bool Tattoo { get; set; }
    }
}
