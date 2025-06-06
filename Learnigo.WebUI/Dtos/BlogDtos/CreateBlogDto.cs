﻿using Learnigo.WebUI.Dtos.BlogCategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.WebUI.Dtos.BlogDtos
{
    public class CreateBlogDto
    {
        
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BlogDate { get; set; } = DateTime.UtcNow;
        public int BlogCategoryId { get; set; }
        
    }
}
