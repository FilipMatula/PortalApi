﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class ArticleSubcategory
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int ArticleCategoryId { get; set; }
        public ArticleCategory ArticleCategory { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
