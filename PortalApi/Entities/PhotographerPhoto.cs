﻿using PortalApi.Enums;
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
        public Person Person { get; set; }
        [Required]
        public int PersonId { get; set; }
        [MaxLength(50)]
        //TODO: Przeniesc do profilu fotografa
        public string City { get; set; }
        [Required]
        //TODO: Przeniesc do profilu fotografa ( nie wyswietlac w zdjeciach)
        public Gender Gender { get; set; }
        [Required]
        public Experience Experience { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        [Required]
        public DateTime Date { get; set; }
    
    }
}