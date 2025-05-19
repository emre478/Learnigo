using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnigo.Entity.Entities
{
    public class Course
    {
        public bool IsShown;

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Image { get; set; }
        public int CourseCategoryId { get; set; }
        public CourseCategory Category { get; set; }
        public decimal Price { get; set; }
        public bool IsShow { get; set; }
    }
}
