﻿using Learnigo.WebUI.Dtos.BlogCategoryDtos;
using Learnigo.WebUI.Dtos.BlogDtos;
using Learnigo.WebUI.Helpers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Learnigo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BlogController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task CategoryDropdown()
        {
            var categoryList = await _client.GetFromJsonAsync<List<ResultBlogCategoryDto>>("categories");
            List<SelectListItem> categories = (from x in categoryList select new SelectListItem
            {
                Text = x.Name,
                Value = x.BlogCategoryId.ToString()     
            }).ToList();
            ViewBag.categories = categories;
        }
        public async Task<IActionResult> Index()
        {

            var values = await _client.GetFromJsonAsync<List<ResultBlogDto>>("blogs");
            return View(values);
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _client.DeleteAsync("blogs/" + id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> CreateBlog()
        {
            await CategoryDropdown();   
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
        {
            await _client.PostAsJsonAsync("blogs", createBlogDto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBlog(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBlogDto>("blogs/" + id);
            return View(values);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            await _client.PutAsJsonAsync("blogs", updateBlogDto);
            return RedirectToAction("Index");
        }
    }
}
