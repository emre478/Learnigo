﻿using AutoMapper;
using Learnigo.Business.Abstract;
using Learnigo.DTO.Dtos.AboutDtos;
using Learnigo.DTO.Dtos.CourseDtos;
using Learnigo.Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController(ICourseService _courseService, IMapper _mapper ) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _courseService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseService.TDelete(id);
            return Ok("Kurs Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateCourseDto createCourseDto)
        {
            var newValue = _mapper.Map<Course>(createCourseDto);
            _courseService.TCreate(newValue);
            return Ok("Yeni Kurs Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseDto updateCourseDto)
        {
            var value = _mapper.Map<Course>(updateCourseDto);
            _courseService.TUpdate(value);
            return Ok("Kurs Alanı Güncellendi");

        }
    }
}
