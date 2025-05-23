﻿using Learnigo.WebUI.Dtos.BannerDtos;
using Learnigo.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BannerController : Controller
    {
        

        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var value = await _client.GetFromJsonAsync<List<ResultBannerDto>>("banners");
            return View(value);
        }

        public async Task<IActionResult> DeleteBanner(int id)
        {
            await _client.DeleteAsync($"banners/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateBanner()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> CreateBanner(CreateBannerDto createBannerDto)
        {
            await _client.PostAsJsonAsync("banners", createBannerDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateBanner(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateBannerDto>($"banners/{id}");
            return View(value);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBannerDto)
        {
            await _client.PutAsJsonAsync("banners", updateBannerDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
