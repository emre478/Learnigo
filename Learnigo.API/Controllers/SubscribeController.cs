using AutoMapper;
using Learnigo.Business.Abstract;
using Learnigo.DTO.Dtos.AboutDtos;
using Learnigo.DTO.Dtos.SubscribeDtos;
using Learnigo.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController(IGenericService<Subscribe> _subscribeService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _subscribeService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subscribeService.TDelete(id);
            return Ok("Abone Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateSubscribeDto createSubscribeDto)
        {
            var newValue = _mapper.Map<Subscribe>(createSubscribeDto);
            _subscribeService.TCreate(newValue);
            return Ok("Yeni Abone Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateSubscribeDto updateSubscribeDto)
        {
            var value = _mapper.Map<Subscribe>(updateSubscribeDto);
            _subscribeService.TUpdate(value);
            return Ok("Abone Alanı Güncellendi");

        }
    }
}
