using AutoMapper;
using Learnigo.DTO.Dtos.SubscribeDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class SubscribeMapping : Profile
    {
        public SubscribeMapping()
        {
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscribe>().ReverseMap();
        }
    }
}
