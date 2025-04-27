using AutoMapper;
using Learnigo.DTO.Dtos.CourseCatagoryDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class CourseCategoryMapping : Profile
    {
        public CourseCategoryMapping()
        {
            CreateMap<CreateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCategoryDto, CourseCategory>().ReverseMap();
        }
    }
}
