using Learnigo.WebUI.Dtos.CourseCategoryDtos;
using Learnigo.WebUI.Dtos.CourseDtos;
using Learnigo.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Learnigo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class CourseController : Controller
    {

        private readonly HttpClient _client = HttpClientInstance.CreateClient();

        public async Task CourseCategoryDropdown()
        {
            var courseCategoryList = await _client.GetFromJsonAsync<List<ResultCourseCategoryDto>>("CourseCategories");

            List<SelectListItem> courseCategories = (from x in courseCategoryList
                                                     select new SelectListItem
                                                     {
                                                         Text = x.CategoryName,
                                                         Value = x.CourseCategoryId.ToString()
                                                     }).ToList();
            ViewBag.CourseCategories = courseCategories;
        }

        public async Task<IActionResult> Index()
        {

            var values = await _client.GetFromJsonAsync<List<ResultCourseDto>>("Course");
            return View(values);
        }

        public async Task<IActionResult> DeleteCourse(int id)
        {
            await _client.DeleteAsync("Course" + id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> CreateCourse()
        {
            await CourseCategoryDropdown();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CreateCourseDto createCourseDto)
        {
            await _client.PostAsJsonAsync("Course", createCourseDto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCourse(int id)
        {
            await CourseCategoryDropdown();
            var values = await _client.GetFromJsonAsync<UpdateCourseDto>("Course" + id);
            return View(values);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateCourse(UpdateCourseDto updateCourseDto)
        {
            await _client.PutAsJsonAsync("Course", updateCourseDto);
            return RedirectToAction("Index");
        }

    }
}
