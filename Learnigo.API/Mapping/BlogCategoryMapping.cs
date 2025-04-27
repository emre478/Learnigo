using AutoMapper;
using Learnigo.DTO.Dtos.BlogCategoryDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class BlogCategoryMapping : Profile
    {
        public BlogCategoryMapping()
        {
            CreateMap<CreateBlogCategoryDto, BlogCategory >().ReverseMap();
            CreateMap<UpdateBlogCategoryDto, BlogCategory >().ReverseMap();
            CreateMap<ResultBlogCategoryDto, BlogCategory >().ReverseMap();
        }
    }
}
