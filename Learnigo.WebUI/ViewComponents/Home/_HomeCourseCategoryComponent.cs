using Learnigo.WebUI.Dtos.CourseCategoryDtos;
using Learnigo.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.WebUI.ViewComponents.Home
{
    public class _HomeCourseCategoryComponent : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultCourseCategoryDto>>("CourseCategories/GetActiveCategories");
            return View(values);
        }
    }
}
