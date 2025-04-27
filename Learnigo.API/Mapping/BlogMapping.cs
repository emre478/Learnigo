using AutoMapper;
using Learnigo.DTO.Dtos.BlogDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class BlogMapping : Profile
    {
        public BlogMapping()
        {
            CreateMap<CreateBlogDto, Blog>().ReverseMap();
            CreateMap<UpdateBlogDto, Blog>().ReverseMap();
            CreateMap<ResultBlogDto, Blog>().ReverseMap();

        }
    }
}
