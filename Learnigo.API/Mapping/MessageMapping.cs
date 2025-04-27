using AutoMapper;
using Learnigo.DTO.Dtos.MessageDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
        }
    }
    
    }

