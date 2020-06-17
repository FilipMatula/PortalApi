using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Models
{
    public class ArticleForCreationDto
    {
        [Required]
        public int? UserId { get; set; }
        [Required]
        public int? ArticleSubcategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(2500)]
        public string Content { get; set; }
        [MaxLength(150)]
        public string ImgSrc { get; set; }
    }
}
