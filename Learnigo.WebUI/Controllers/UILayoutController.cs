using Microsoft.AspNetCore.Mvc;

namespace Learnigo.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
