﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.DTO.Dtos.TestimonialDtos
{
    public class CreateTestimonialDto
    {
        
        public int Name { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Comment { get; set; }
        public int Star { get; set; }
    }
}
