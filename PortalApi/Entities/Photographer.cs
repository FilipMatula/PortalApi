﻿using PortalApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Photographer
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        [MaxLength(150)]
        public string City { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public Experience Experience { get; set; }
        [MaxLength(1500)]
        public string About { get; set; }
        [MaxLength(150)]
        public string MediaFB { get; set; }
        [MaxLength(150)]
        public string MediaInstagram { get; set; }
        [MaxLength(150)]
        public string MediaTwitter { get; set; }
        //public List<JobTags> JobTags { get; set; } = new List<JobTags>();
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        //[Required]
        public DateTime RegistrationDate { get; set; }
    }
}
