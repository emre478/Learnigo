using AutoMapper;
using Learnigo.DTO.Dtos.SocialMediaDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<CreateSocialMediaDto, SocialMedia>().ReverseMap();
            CreateMap<UpdateSocialMediaDto, SocialMedia>().ReverseMap();
        }
    }
}
