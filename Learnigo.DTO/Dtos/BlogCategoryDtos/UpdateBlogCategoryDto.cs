using Learnigo.DTO.Dtos.BlogDtos;
using Learnigo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.DTO.Dtos.BlogCategoryDtos
{
    public class UpdateBlogCategoryDto
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
        public List<ResultBlogDto> Blogs { get; set; }
    }
}
