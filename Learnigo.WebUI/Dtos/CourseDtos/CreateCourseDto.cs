namespace Learnigo.WebUI.Dtos.CourseDtos
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
