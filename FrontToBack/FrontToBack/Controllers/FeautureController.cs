using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers {
    public class FeautureController : Controller {
        public IActionResult Index()
        {
            return View();
        }
    }
}
