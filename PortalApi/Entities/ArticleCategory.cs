using Microsoft.AspNetCore.Mvc.RazorPages;
using PortalApi.ProfilesProperties;
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
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public ArticleType ArticleType { get; set; }
        public List<ArticleSubcategory> Subcategories { get; set; } = new List<ArticleSubcategory>();
    }
}
