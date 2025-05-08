using Learnigo.WebUI.Dtos.AboutDtos;
using Learnigo.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AboutController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
           
            var values = await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");
            return View(values);
        }
    }
}
