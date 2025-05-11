using AutoMapper;
using Learnigo.Business.Abstract;
using Learnigo.DTO.Dtos.AboutDtos;
using Learnigo.DTO.Dtos.BlogDtos;
using Learnigo.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IMapper _mapper, IBlogService _blogService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogService.TGetBlogsWithCategories();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _blogService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogDto createBlogDto)
        {
            var newValue = _mapper.Map<Blog>(createBlogDto);
            _blogService.TCreate(newValue);
            return Ok("Yeni Blog Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBlogDto updateBlogDto)
        {
            var value = _mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(value);
            return Ok("Blog Alanı Güncellendi");

        }
    }
}
