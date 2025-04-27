using Learnigo.DTO.Dtos.BlogCategoryDtos;
using Learnigo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.DTO.Dtos.BlogDtos
{
    public class CreateBlogDto
    {
        
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BlogDate { get; set; }
        public int BlogCategoryId { get; set; }
        
    }
}
