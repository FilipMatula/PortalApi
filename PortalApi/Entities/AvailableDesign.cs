﻿using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class AvailableDesign
    {
        [Key]
        public int Id { get; set; }
        public Tattooer Tattooer { get; set; }
        [Required]
        public int TattooerId { get; set; }
        [Required]
        public Style Style { get; set; }
        [Required]
        public Color Color { get; set; }
        [Required]
        public Technique Technique { get; set; }
        public double? Price { get; set; }
        public bool Reserved { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
