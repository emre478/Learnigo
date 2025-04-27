using Learnigo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.DTO.Dtos.CourseCatagoryDtos
{
    public class CreateCourseCategoryDto
    {
       
        public string CategoryName { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsShow { get; set; }
        
    }
}
