using Learnigo.WebUI.Dtos.CourseCategoryDtos;

namespace Learnigo.WebUI.Dtos.CourseDtos
{
    public class ResultCourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Image { get; set; }
        public int CourseCategoryId { get; set; }
        public ResultCourseCategoryDto Category { get; set; }
        public decimal Price { get; set; }
        public bool IsShow { get; set; }
    }
}
