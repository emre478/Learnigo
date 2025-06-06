﻿using Learnigo.WebUI.Dtos.BlogCategoryDtos;
using Learnigo.WebUI.Helpers;
using Learnigo.WebUI.Validators;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BlogCategoryController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {

            var values = await _client.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogcategories");
            return View(values);
        }

        public async Task<IActionResult> DeleteBlogCategory(int id)
        {
            await _client.DeleteAsync($"blogcategories/{id}");
            return RedirectToAction(nameof(Index));
             
        }

        public IActionResult CreateBlogCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlogCategory(CreateBlogCategoryDto createBlogCategoryDto)
        {

            var validator = new BlogCategoryValidator();
            var result = await validator.ValidateAsync(createBlogCategoryDto);
            if (!result.IsValid)
            {
                foreach (var x in result.Errors)
                {
                    ModelState.Clear();
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }
            await _client.PostAsJsonAsync("blogcategories", createBlogCategoryDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateBlogCategory(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBlogCategoryDto>($"blogcategories/{id}");
            return View(values);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateBlogCategory(UpdateBlogCategoryDto updateBlogCategoryDto)
        {
            await _client.PutAsJsonAsync("blogcategories", updateBlogCategoryDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
