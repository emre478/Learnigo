using Learnigo.WebUI.Dtos.CourseDtos;
using Learnigo.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.WebUI.ViewComponents.Home
{
    public class _HomeCourseComponent : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultCourseDto>>("Course/GetActiveCourses");
            return View(values);
        }
    }
}
