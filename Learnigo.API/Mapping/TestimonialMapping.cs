using AutoMapper;
using Learnigo.DTO.Dtos.TestimonialDtos;
using Learnigo.Entity.Entities;

namespace Learnigo.API.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            
        }
    }
    
    }

