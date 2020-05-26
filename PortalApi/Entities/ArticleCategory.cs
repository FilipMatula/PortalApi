﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Entities
{
    public class ArticleCategory
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public List<ArticleSubCategory> SubCategories { get; set; } = new List<ArticleSubCategory>();
    }
}