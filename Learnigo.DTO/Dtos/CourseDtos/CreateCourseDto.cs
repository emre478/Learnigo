﻿using Learnigo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.DTO.Dtos.CourseDtos
{
    public class CreateCourseDto
    {
        
        public string CourseName { get; set; }
        public string Image { get; set; }
        public int CourseCategoryId { get; set; }
        
        public decimal Price { get; set; }
        public bool IsShow { get; set; }
    }
}
