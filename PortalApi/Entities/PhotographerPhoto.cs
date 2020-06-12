﻿using PortalApi.ProfilesProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class PhotographerPhoto
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public ModelingStyle Style { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        [Required]
        public DateTime Date { get; set; }
    
    }
}
