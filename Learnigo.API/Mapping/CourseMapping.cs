using AutoMapper;
using Learnigo.DTO.Dtos.CourseDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<CreateCourseDto, Course>().ReverseMap();
            CreateMap<UpdateCourseDto, Course>().ReverseMap();
            CreateMap<ResultCourseDto, Course>().ReverseMap();
        }
    }
}
