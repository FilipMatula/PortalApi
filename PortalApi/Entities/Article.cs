﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        public ArticleSubcategory ArticleSubcategory { get; set; }
        [Required]
        public int ArticleSubcategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(2500)]
        public string Content { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
