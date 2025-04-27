using AutoMapper;
using Learnigo.Business.Abstract;
using Learnigo.DTO.Dtos.AboutDtos;
using Learnigo.DTO.Dtos.BannerDtos;
using Learnigo.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Learnigo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _bannerService,IMapper _mapper) : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            var values = _bannerService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _bannerService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bannerService.TDelete(id);
            return Ok("Hakkımızda Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBannerDto createBannerDto)
        {
            var newValue = _mapper.Map<Banner>(createBannerDto);
            _bannerService.TCreate(newValue);
            return Ok("Yeni Hakkımızda Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {
            var value = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.TUpdate(value);
            return Ok("Hakkımda Alanı Güncellendi");

        }
    }
}
