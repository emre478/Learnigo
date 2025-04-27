using AutoMapper;
using Learnigo.DTO.Dtos.BannerDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<CreateBannerDto, Banner>().ReverseMap();
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();
        }
    }
}
