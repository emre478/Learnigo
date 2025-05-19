using Learnigo.WebUI.Dtos.MessageDtos;
using Learnigo.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Learnigo.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {

            var values = await _client.GetFromJsonAsync<List<ResultMessageDto>>("Message");
            return View(values);
        }

        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _client.DeleteAsync("Message/" + id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> CreateMessage()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageDto createMessageDto)
        {
            await _client.PostAsJsonAsync("Message", createMessageDto);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateMessage(int id)
        {
            
            var values = await _client.GetFromJsonAsync<UpdateMessageDto>("Message" + id);
            return View(values);
        }

        [HttpPost]

        public async Task<IActionResult> UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            await _client.PutAsJsonAsync("Message", updateMessageDto);
            return RedirectToAction("Index");
        }
    }
}
