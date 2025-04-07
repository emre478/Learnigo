using AutoMapper;
using Learnigo.DTO.Dtos.AboutDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
