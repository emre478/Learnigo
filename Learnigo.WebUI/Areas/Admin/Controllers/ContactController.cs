using Learnigo.WebUI.Dtos.ContactDtos;
using Learnigo.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ContactController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {

            var values = await _client.GetFromJsonAsync<List<ResultContactDto>>("Contact");
            return View(values);
        }

        public async Task<IActionResult> DeleteContact(int id)
        {
            await _client.DeleteAsync("Contact" + id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult CreateContact()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            await _client.PostAsJsonAsync("Contact", createContactDto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateContact(int id)
        {
           
            var values = await _client.GetFromJsonAsync<UpdateContactDto>("Contact" + id);
            return View(values);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
        {
            await _client.PutAsJsonAsync("Contact", updateContactDto);
            return RedirectToAction("Index");
        }
    }
}
