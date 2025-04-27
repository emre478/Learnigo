using AutoMapper;
using Learnigo.DTO.Dtos.ContactDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
        }
    }
}
